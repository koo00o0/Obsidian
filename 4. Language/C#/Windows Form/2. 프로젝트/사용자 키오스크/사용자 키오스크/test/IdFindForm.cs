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
    public partial class IdFindForm : Form
    {
        private const string connectionString = "Server=DESKTOP-R04VI57\\MSSQLSERVER1;Database=model;Uid=sa;Pwd=1234";
        private string qu = "";

        public IdFindForm()
        {
            InitializeComponent();
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

        private void txtQUESTION_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            qu = cb.SelectedItem.ToString();
        }
        
        private void findid_Click(object sender, EventArgs e)
        {
            string pw = txtPASSWORD.Text;
            string name = txtNAME.Text;
            string answer = txtANSWER.Text;
            Login form1 = new Login();

            string result = find(pw, name, qu, answer);
            Console.WriteLine(result + "아아아아");

            if (result == "F")
            {
                MessageBox.Show("아이디 찾기 실패");
                return;
            }
            else if (result == "E")
            {
                MessageBox.Show(" 에러");
                return;
            }
            else
            {
                MessageBox.Show(result + " : 회원 아이디 입니다 ");
                this.Hide();
                form1.Show();
            }
        }

        private string find(string pw, string name, string qu, string answer)
        {
            Console.WriteLine(pw + ": 비밀번호");
            Console.WriteLine(name + ": 이름");
            Console.WriteLine(qu + ": 질문");
            Console.WriteLine(answer + ": 비밀번호");
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("FINDID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Pw", pw);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Question", qu);
                        command.Parameters.AddWithValue("@Answer", answer);

                        SqlParameter resultParam = new SqlParameter("@Result", SqlDbType.NVarChar, 100);
                        resultParam.Direction = ParameterDirection.Output;
                        command.Parameters.Add(resultParam);

                        command.ExecuteReader();

                        return resultParam.Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return "E";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login form1 = new Login();
            this.Hide();
            form1.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
