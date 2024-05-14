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
    public partial class JoinForm : Form
    {
        private const string connectionString = "Server=DESKTOP-R04VI57\\MSSQLSERVER1;Database=model;Uid=sa;Pwd=1234";
        private string qu = "";
        private readonly DBHelper dbHelper;

        public JoinForm()
        {
            InitializeComponent();
            dbHelper = new DBHelper(connectionString);

            this.Shown += MainCombo;
        }

        public void MainCombo(object sender, EventArgs e)
        {
            combostart();
        }

        private void combostart()
        {
            string[] data = { "1.기억에 남는 장소", "2.좋아하는 음식", "3.본인 별명", "4.본인 취미", "5.본인 별자리" };
            txtQUESTION.Items.AddRange(data);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            qu = cb.SelectedItem.ToString();
        }

        //회원 아이디 중복체크
        private void idCheck_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;

            if (id.Equals(""))
            {
                MessageBox.Show("아이디를 입력해주세요");
                return;
            }
            SqlParameter[] parameters = { new SqlParameter("@Id", id) };

            string result = dbHelper.ExecuteScalar("IDCHECK", CommandType.StoredProcedure, parameters);

            MessageBox.Show(result == "T" ? "사용중인 아이디" : "사용가능한 아이디입니다!");
        }

        //회원가입
        private void signup_Click_1(object sender, EventArgs e)
        {
            string name = txtNAME.Text;
            string id = txtID.Text;
            string pw = txtPW.Text;
            string pw2 = txtPW2.Text;
            string answer = txtANSWER.Text;
            Login form1 = new Login();

            if (name == "")
            {
                MessageBox.Show("이름을 입력해주세요");
                this.ActiveControl = txtNAME;
                return;
            }
            else if (id == "")
            {
                MessageBox.Show("아이디를 입력해주세요");
                this.ActiveControl = txtID;
                return;
            }
            else if (pw == "")
            {
                MessageBox.Show("비밀번호를 입력해주세요");
                this.ActiveControl = txtPW;
                return;
            }
            else if (pw2 == "")
            {
                MessageBox.Show("비밀번호를 재입력해주세요");
                this.ActiveControl = txtPW2;
                return;
            }
            else if (pw2 != pw)
            {
                MessageBox.Show("비밀번호가 다릅니다 다시 입력해주세요");
                this.ActiveControl = txtPW2;
                return;
            }
            else if (qu == "")
            {
                MessageBox.Show("질문을 선택해주세요");
                this.ActiveControl = txtQUESTION;
                return;
            }
            else if (answer == "")
            {
                MessageBox.Show("질문 답을 입력해주세요");
                this.ActiveControl = txtANSWER;
                return;
            }

            SqlParameter[] parameters =
 {
                new SqlParameter("@Id", id),
                new SqlParameter("@Pw", pw),
                new SqlParameter("@Name", name),
                new SqlParameter("@Question", qu),
                new SqlParameter("@Answer", answer),
                new SqlParameter("@Result", SqlDbType.NVarChar, 100) {Direction = ParameterDirection.Output}
            };

            string result = dbHelper.ExecuteNonQuery("SIGNUP", CommandType.StoredProcedure, parameters);

            if (result == "T")
            {
                MessageBox.Show("회원가입 성공");
                Login form = new Login();
                this.Hide();
                form1.Show();
            }
            else
            {
                MessageBox.Show("회원가입 실패");
            }
        }

        private void Gologin_Click(object sender, EventArgs e)
        {
            Login form1 = new Login();
            this.Hide();
            form1.Show();
        }
    }
}
