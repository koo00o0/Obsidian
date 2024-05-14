using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private const string connectionString = "Server=DESKTOP-R04VI57\\MSSQLSERVER1;Database=master;Uid=sa;Pwd=1234";
        private readonly DBHelper dbHelper;

        public Form1()
        {
            InitializeComponent();
            dbHelper = new DBHelper(connectionString);
        }


        private void idCheck_Click(object sender, EventArgs e)
        {
            string id = userId.Text.Trim();

            Console.WriteLine($"{ id} 아이디 잘 들어와 ???");
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("아이디를 입력해주세요");
                return;
            }

            SqlParameter[] parameters = { new SqlParameter("@Id", id) };

            string result = dbHelper.ExecuteScalar("sp_RegisterIdCheck", CommandType.StoredProcedure, parameters);

            MessageBox.Show(result == "T" ? "사용중인 아이디" : "사용가능한 아이디입니다!");
        }

        private void userJoin_Click(object sender, EventArgs e)
        {
            string id = userId.Text.Trim();
            string password = userPw.Text;
            string name = userName.Text.Trim();

            Console.WriteLine($"{id} {password} {name} 값 잘 들어오고 있어 ???");

            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("아이디, 비밀번호, 이름을 모두 입력해주세요");
                return;
            }

            SqlParameter[] parameters =
            {
                new SqlParameter("@Id", id),
                new SqlParameter("@Pw", password),
                new SqlParameter("@Name", name),
                new SqlParameter("@Result", SqlDbType.NVarChar, 100) {Direction = ParameterDirection.Output}
            };

            string result = dbHelper.ExecuteNonQuery("sp_RegisterUser", CommandType.StoredProcedure, parameters);

            if (result == "T")
            {
                MessageBox.Show("회원가입 성공");
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("회원가입 실패");
            }
        }

        private void LoginFormN_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}