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
    public partial class PwFindForm : Form
    {
        private const string connectionString = "Server=DESKTOP-R04VI57\\MSSQLSERVER1;Database=model;Uid=sa;Pwd=1234";
        private string qu = "";
        private readonly DBHelper dbHelper;


        public PwFindForm()
        {
            InitializeComponent();
            this.Shown += MainCombo;
            dbHelper = new DBHelper(connectionString);

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

        private void findpassword_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string name = txtNAME.Text;
            string answer = txtANSWER.Text;

            SqlParameter[] parameters = {

                new SqlParameter("@Id", id),
                new SqlParameter("@Name", name),
                new SqlParameter("@Question", qu),
                new SqlParameter("@Answer", answer)
            };

            string result = dbHelper.ExecuteScalar("FINDPASSWORD", CommandType.StoredProcedure, parameters);


            MessageBox.Show(result != "error" ? "비밀번호 : " + result : "아이디 이름을 다시 확인해주세요!");

            Login login = new Login();
            login.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            this.Hide();
            form.Show();
        }
    }
}