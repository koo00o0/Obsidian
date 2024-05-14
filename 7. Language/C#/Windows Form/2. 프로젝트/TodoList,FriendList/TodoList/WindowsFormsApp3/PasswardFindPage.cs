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
    public partial class PasswardFindPage : Form
    {
        private readonly DBHelper dbHelper;
        private const string connectionString = "Server=DESKTOP-R04VI57\\MSSQLSERVER1;Database=master;Uid=sa;Pwd=1234";

        public PasswardFindPage()
        {
            InitializeComponent();
            dbHelper = new DBHelper(connectionString);
        }

        private void PasswardFindPage_Load(object sender, EventArgs e)
        {
            
        }

        private void passwardF_Click(object sender, EventArgs e)
        {
            string id = userId.Text.Trim();
            string name = userName.Text.Trim();

            Console.WriteLine($"{ id} 아이디 잘 들어와 ???");
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("아이디를 입력해주세요");
                return;
            }

            SqlParameter[] parameters = {

                new SqlParameter("@Id", id),
                new SqlParameter("@Name", name)
            };

            string result = dbHelper.ExecuteScalar("sp_UserPwFind", CommandType.StoredProcedure, parameters);

            Console.WriteLine(result + "잘넘어와 ??");

            MessageBox.Show(result != "error" ? "비밀번호 : " +result  : "아이디 이름을 다시 확인해주세요!");

            LoginForm login = new LoginForm();
            login.Show();


        }
    }
}
