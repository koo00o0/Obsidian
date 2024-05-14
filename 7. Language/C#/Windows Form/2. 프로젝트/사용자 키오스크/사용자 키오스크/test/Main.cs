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
    public partial class Main : Form
    {
        private const string connectionString = "Server=DESKTOP-R04VI57\\MSSQLSERVER1;Database=model;Uid=sa;Pwd=1234";
        private readonly DBHelper dbHelper;
        private string SessionId;
        private string RankName;
        int userPayMoney;
        int userMoney;

        public Main(string id)
        {
            InitializeComponent();
            dbHelper = new DBHelper(connectionString);
            SessionId = id;
            UIdsession.Text = "회원 ID : " + SessionId;
            LoadUserMoney();
        }

        private void LoadUserMoney()
        {

            SqlParameter[] parameters = {
                new SqlParameter("@Id", SessionId),
                new SqlParameter("@Result",SqlDbType.NVarChar,100){Direction=ParameterDirection.Output}
            };

            string result = dbHelper.ExecuteNonQuery("SP_LoadUserMoney", CommandType.StoredProcedure, parameters);

            int resultMoney = Convert.ToInt32(result);
            userMoney = resultMoney;

            if (result != null)
            {
                Money.Text = result + "원";
                LoadUserRenk();
            }

        }



        private void LoadUserRenk()
        {

            SqlParameter[] parameters = {
                new SqlParameter("@Id", SessionId),
                new SqlParameter("@Result",SqlDbType.NVarChar,100){Direction=ParameterDirection.Output}
            };

            string result = dbHelper.ExecuteNonQuery("SP_LoadUserPayMoney", CommandType.StoredProcedure, parameters);

            userPayMoney = Convert.ToInt32(result);

            if (userPayMoney >= 100000)
            {
                Rank.Text = "★ V I P ★";
                RankName = "★ V I P ★";
                return;
            }
            else if (userPayMoney >= 50000)
            {
                Rank.Text = "골드 회원";
                RankName = "골드 회원";
                return;
            }
            else
            {
                Rank.Text = "일반 회원";
                RankName = "일반 회원";
                return;
            }
        }


        private void Store_Click(object sender, EventArgs e)
        {
            CafeMenu form = new CafeMenu(SessionId,RankName, userMoney, userPayMoney);
            this.Hide();
            form.Show();
        }

        private void HighlowB_Click(object sender, EventArgs e)
        {
            Highlow form = new Highlow(SessionId, userMoney);
            form.Show();
            this.Hide();

        }
    }
}