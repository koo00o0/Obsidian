using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Login : Form
    {
        private const string connectionString = "Server=DESKTOP-R04VI57\\MSSQLSERVER1;Database=model;Uid=sa;Pwd=1234";
        private readonly DBHelper dbHelper;

        public Login()
        { 
            InitializeComponent();
            dbHelper = new DBHelper(connectionString);

        }

        public static class Session_Management
        {
            public static string sessionId { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string pw = txtPW.Text;
            if (id == "")
            {
                MessageBox.Show("아이디 입력 바랍니다");
                return;
            }
            else if (pw == "")
            {
                MessageBox.Show("비밀번호 입력 바랍니다");
                return;
            }


            SqlParameter[] parameters = {
                new SqlParameter("@Id", id),
                new SqlParameter("@Pw", pw)
            };

            string result = dbHelper.ExecuteScalar("USERLOGIN", CommandType.StoredProcedure, parameters);

            if (result == "T")
            {
                MessageBox.Show("로그인 성공");
                Session_Management.sessionId = id;

                if (Session_Management.sessionId == "admin")
                {
                    Adminpage form = new Adminpage(id);
                    form.Show();
                }
                else
                {
                    Main form1 = new Main(id);
                    form1.Show();
                }
            }
            else if (result == "F")
            {
                MessageBox.Show("없는 계정입니다");
                return;
            }
            else if (result == "L")
            {
                MessageBox.Show("계정이 잠겼습니다");
                return;
            }
            else if (result == "E")
            {
                MessageBox.Show("에러");
                return;
            }
            else
            {
                MessageBox.Show("비밀번호 " + result + "회 틀림 ");
                return;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            JoinForm form2 = new JoinForm();
            this.Hide();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PwFindForm form = new PwFindForm();
            this.Hide();
            form.Show();
        }

        private void idFindPage_Click(object sender, EventArgs e)
        {
            IdFindForm form = new IdFindForm();
            this.Hide();
            form.Show();
        }
    }
}
