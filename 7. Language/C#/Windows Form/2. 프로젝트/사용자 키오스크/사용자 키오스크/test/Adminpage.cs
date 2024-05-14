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
    public partial class Adminpage : Form
    {
        private const string connectionString = "Server=DESKTOP-R04VI57\\MSSQLSERVER1;Database=model;Uid=sa;Pwd=1234";
        private readonly DBHelper dbHelper;
        private string SessionId;

        public Adminpage(string id)
        {
            InitializeComponent();
            dbHelper = new DBHelper(connectionString);
            SessionId = id;
            AIdsession.Text = "관리자 ID : " + SessionId;
        }

        private void UserProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            Profile();
        }

        private void Profile()
        {
            DataTable dataTable = dbHelper.ExecuteDataTable("USERPROFILE", CommandType.StoredProcedure, new SqlParameter("@Id", SessionId));
            UserProfileBox.DataSource = dataTable;

            List<string> userList = new List<string>();

            for (int i = 0; i < UserProfileBox.Items.Count; i++)
            {
                DataRowView dataRowView = (DataRowView)UserProfileBox.Items[i];

                string contextValue = dataRowView["userId"].ToString();
                string contextValue1= dataRowView["userLock"].ToString();
                string plus = contextValue + "\t상태: " + contextValue1;

                Button[] btn_clone = new Button[100];
                Button[] btn_clone2 = new Button[100];
                Button[] btn_clone3 = new Button[100];

                btn_clone[i] = new Button();
                btn_clone2[i] = new Button();
                btn_clone3[i] = new Button();

                btn_clone[i].Text = "잠금";
                btn_clone2[i].Text = "해제";
                btn_clone3[i].Text = "정보";

                btn_clone[i].Tag = contextValue;
                btn_clone2[i].Tag = contextValue;
                btn_clone3[i].Tag = contextValue;

                btn_clone[i].Click += btn_clone_click;
                btn_clone2[i].Click += btn_clone_click2;
                btn_clone3[i].Click += btn_clone_click3;

                btn_clone[i].FlatStyle = FlatStyle.Standard;
                btn_clone2[i].FlatStyle = FlatStyle.Standard;
                btn_clone3[i].FlatStyle = FlatStyle.Standard;

                btn_clone[i].Location = new Point(175, -3 + i * 17);
                btn_clone2[i].Location = new Point(220, -3 + i * 17);
                btn_clone3[i].Location = new Point(265, -3 + i * 17);

                btn_clone[i].Size = new Size(43, 21);
                btn_clone2[i].Size = new Size(43, 21);
                btn_clone3[i].Size = new Size(43, 21);

                btn_clone[i].Font = new Font("굴림", 8);
                btn_clone2[i].Font = new Font("굴림", 8);
                btn_clone3[i].Font = new Font("굴림", 8);

                btn_clone[i].BackColor = Color.Orange;
                btn_clone2[i].BackColor = Color.Aqua;
                btn_clone3[i].BackColor = Color.LawnGreen;

                UserProfileBox.Controls.Add(btn_clone[i]);
                UserProfileBox.Controls.Add(btn_clone2[i]);
                UserProfileBox.Controls.Add(btn_clone3[i]);

                userList.Add(plus);
            }
            UserProfileBox.DataSource = userList;

        }
        private void btn_clone_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string result = btn.Tag.ToString();

            SqlParameter[] parameters = {
                new SqlParameter("@Id", result),
                new SqlParameter("@Result",SqlDbType.NVarChar,100){Direction=ParameterDirection.Output}
            };

            string resultP = dbHelper.ExecuteNonQuery("SP_USERLOCK", CommandType.StoredProcedure, parameters);

            if (resultP == "T")
            {
                MessageBox.Show("계정 잠갔습니다");
                Profile();
            }
            else
            {
                MessageBox.Show("계정 잠겨있습니다");
            }
        }



        private void btn_clone_click2(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string result = btn.Tag.ToString();

            SqlParameter[] parameters = {
                new SqlParameter("@Id", result),
                new SqlParameter("@Result",SqlDbType.NVarChar,100){Direction=ParameterDirection.Output}
            };

            string resultP = dbHelper.ExecuteNonQuery("SP_USERUNLOCK", CommandType.StoredProcedure, parameters);

            if (resultP == "T")
            {
                MessageBox.Show("계정 잠금 해제하였습니다");
                Profile();
            }
            else
            {
                MessageBox.Show("계정 잠금 해제되어있습니다");
            }

        }
        private void btn_clone_click3(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string resultID = btn.Tag.ToString();



            SqlParameter[] parameters = {
                new SqlParameter("@Id", resultID)
            };

            List<string> resultP = dbHelper.ExecuteReaderList("USERINFODATA", CommandType.StoredProcedure, parameters);

            Console.WriteLine(resultP.ToString()+"들어옴 ?? ");

            string id = "";
            string Lock = "";
            string name = "";
            if (resultP.Count > 0)
            {

                 id = resultP[0];
                 name = resultP[1];
                 Lock = resultP[2];

                Console.WriteLine("User Id: " + id);
                Console.WriteLine("User Name: " + name);
                Console.WriteLine("Lock Status: " + Lock);
            }
            else
            {
                // 사용자 정보가 없는 경우
                Console.WriteLine("해당하는 사용자가 없습니다.");
            }


            if (Lock == "Y")
            {
                Lock = "잠금";
            }
            else
            {
                Lock = "사용중";
            }
            UserInfo form = new UserInfo(id, name, Lock);
            form.Show();

        }
        private void UserProfileBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MenuManagement_Click(object sender, EventArgs e)
        {
            MenuManagementPage form = new MenuManagementPage(SessionId);
            form.Show();
        }
    }
}
