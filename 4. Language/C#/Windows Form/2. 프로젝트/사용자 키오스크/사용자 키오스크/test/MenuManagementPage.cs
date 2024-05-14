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
    public partial class MenuManagementPage : Form
    {
        private const string connectionString = "Server=DESKTOP-R04VI57\\MSSQLSERVER1;Database=model;Uid=sa;Pwd=1234";
        private string SessionId;
        private readonly DBHelper dbHelper;

        public MenuManagementPage(string id)
        {
            InitializeComponent();
            dbHelper = new DBHelper(connectionString);
        }

        private void MenuAdd_Click(object sender, EventArgs e)
        {
            string MenuName = AddMenuName.Text.Trim();
            string MenuPrice = AddMenuPrice.Text.Trim();


            SqlParameter[] parameters = {
                new SqlParameter("@MenuName", MenuName),
                new SqlParameter("@MenuPrice",MenuPrice ),
                new SqlParameter("@Result",SqlDbType.NVarChar,100){Direction=ParameterDirection.Output}
            };

            string result = dbHelper.ExecuteNonQuery("SP_CafeMenuListAdd", CommandType.StoredProcedure, parameters);


            if (result == "T")
            {
                MessageBox.Show($"{MenuName} > 메뉴가 추가되었습니다");
            }
            else
            {
                MessageBox.Show("추가 실패");
            }
        }

        private void MenuDelete_Click(object sender, EventArgs e)
        {
            string MenuName = DeMenuName.Text.Trim();

            SqlParameter[] parameters = {
                new SqlParameter("@MenuName", MenuName),
                new SqlParameter("@Result",SqlDbType.NVarChar,100){Direction=ParameterDirection.Output}
            };

            string result = dbHelper.ExecuteNonQuery("SP_CafeMenuListDelete", CommandType.StoredProcedure, parameters);


            if (result == "T")
            {
                MessageBox.Show($"{MenuName} > 메뉴가 삭제되었습니다");
            }
            else
            {
                MessageBox.Show("삭제 실패");
            }
        }
    }
}
