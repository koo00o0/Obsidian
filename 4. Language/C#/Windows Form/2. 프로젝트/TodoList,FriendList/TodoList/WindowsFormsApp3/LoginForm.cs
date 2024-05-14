using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class LoginForm : Form
    {
        private const string connectionString = "Server=DESKTOP-R04VI57\\MSSQLSERVER1;Database=master;Uid=sa;Pwd=1234";
        private readonly DBHelper dbHelper;


        public LoginForm()
        {
            InitializeComponent();
            dbHelper = new DBHelper(connectionString);

        }

        public static class SessionManager
        {
            public static string SessionID { get; set; }
            // 다른 필요한 세션 정보들도 추가할 수 있음
        }


        private void Login_Click(object sender, EventArgs e)
        {
            string id = userId.Text;
            string pw = userPw.Text;
            
            Console.WriteLine($"{ id} {pw} 아이디 잘 들어와 ???");
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("아이디를 입력해주세요");
                return;
            }
            else if (string.IsNullOrWhiteSpace(pw))
            {
                MessageBox.Show("비밀번호를 입력해주세요.");
                return;
            }

            SqlParameter[] parameters = {
                new SqlParameter("@Id", id),
                new SqlParameter("@Pw", pw)

            };

            string result = dbHelper.ExecuteScalar("sp_LoginUser", CommandType.StoredProcedure, parameters);

            if (result == "T")
            {
                MessageBox.Show("로그인 성공");
                SessionManager.SessionID = id;
                Index main = new Index(SessionManager.SessionID);
                main.Show();
            }
            else
            {
                MessageBox.Show("로그인 실패");
            }
        }
        private void passwardFind_Click(object sender, EventArgs e)
        {
            PasswardFindPage PasswardFindPage = new PasswardFindPage();

            PasswardFindPage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
            
            form1.Show();
            this.Hide();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
