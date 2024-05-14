using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class CafeMenu : Form
    {
        private const string connectionString = "Server=DESKTOP-R04VI57\\MSSQLSERVER1;Database=model;Uid=sa;Pwd=1234";
        private readonly DBHelper dbHelper;
        private string SessionId;
        private int sum;
        private string RankName;
        private Double resultD;
        private string resultSS;
        int userMoney;
        int userPayMoney;

        public CafeMenu(string id,string RankName,int userMoney,int userPayMoney)
        {

            InitializeComponent();
            this.RankName = RankName;
            this.userMoney = userMoney;
            this.userPayMoney = userPayMoney;
            dbHelper = new DBHelper(connectionString);
            SessionId = id;

            LoadMenuList();
        }

        private void LoadMenuList()
        {
            
            DataTable dataTable = dbHelper.ExecuteDataTable("SP_GETCAFEMENULIST", CommandType.StoredProcedure);

            int buttonWidth = 140;
            int buttonHeight = 80;
            int buttonSpacingY = 100;
            string IdValue = "";

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow dataRow = dataTable.Rows[i];

                string cafeMenuName = dataRow["CafeMenuName"].ToString();
                string cafeMenuPrice = dataRow["CafeMenuPrice"].ToString();


                Button btnMenu = new Button();
                btnMenu.Text = cafeMenuName+"    " +cafeMenuPrice;
                btnMenu.Tag = new { Name = cafeMenuName, Price = cafeMenuPrice };

                btnMenu.Click += btnMenuBoxList_Click;

                int buttonX = 45 + i * (buttonHeight + buttonSpacingY);
                int buttonY = 110 ;

                btnMenu.Location = new Point(buttonX, buttonY);
                btnMenu.Size = new Size(buttonWidth, buttonHeight);
                btnMenu.Font = new Font("Microsoft Sans Serif", 15);
                btnMenu.ForeColor = Color.Blue;
                btnMenu.BackColor = Color.SkyBlue;

                // Add the button to the form's Controls collection
                Controls.Add(btnMenu);
              
                LoadMenuBoxData();
            }
        }

        private void LoadMenuBoxData()
        {
            DataTable dataTable = dbHelper.ExecuteDataTable("SP_USERMENUBOX", CommandType.StoredProcedure, new SqlParameter("@Id", SessionId));
            menuListBox.DataSource = dataTable;
            menuListBox.DisplayMember = "CafeMenuName";

            //버튼만들기~!
            Button[] btnDelete = new Button[100];
            int buttonWidth = 90;
            int buttonHeight = 17;
            int buttonSpacingY = 0;

            menuListBox.Controls.Clear();
            
            for (int i = 0; i < menuListBox.Items.Count; i++)
            {
                DataRowView dataRowView = (DataRowView)menuListBox.Items[i];

                string contextValue = dataRowView["CafeMenuName"].ToString();
                string contextValue1 = dataRowView["CafeMenuPrice"].ToString();

                btnDelete[i] = new Button();
                btnDelete[i].Text = "삭제 "; 
                btnDelete[i].Tag = contextValue ;

                btnDelete[i].Click += BtnDelete_Click;
                int buttonX = 400;

                int buttonY = -6 + i * (buttonHeight + buttonSpacingY);

                btnDelete[i].Location = new Point(buttonX, buttonY);
                btnDelete[i].Size = new Size(buttonWidth, buttonHeight);
                btnDelete[i].Font = new Font("굴림", 8);
                menuListBox.Controls.Add(btnDelete[i]);

            }
                LoadCafeSumPay();

        }


        private void LoadCafeSumPay()
        {

            SqlParameter[] parameters = {
                new SqlParameter("@Id", SessionId)
            };

            int result = dbHelper.ExecuteReader("SP_LoadCafeMenuBoxSum", CommandType.StoredProcedure, parameters);
            
            string resultS = result.ToString();
            SumMoney.Text = resultS + "원";

            int resultI = Convert.ToInt32(resultS);

            if (RankName.Equals("일반 회원"))
            {
                discount.Text = "할인 없음";
                resultSS = resultS;
                MoneySum.Text = resultSS + " 원";
                return;
            }
            else if (RankName.Equals("골드 회원"))
            {
                resultD = resultI * 0.93;
                resultSS = resultD.ToString();
                discount.Text = RankName +" 7% 적용";
                MoneySum.Text = resultSS + " 원";
                return;
            }
            else if (RankName.Equals("★ V I P ★"))
            {
                resultD = resultI * 0.9;
                resultSS = resultD.ToString();
                discount.Text = RankName+ " 10% 적용";
                MoneySum.Text = resultSS + " 원";
                return;
            }

        }


        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string CafeMenuName = btn.Tag.ToString();

            SqlParameter[] parameters = {
                new SqlParameter("@Id", SessionId),
                new SqlParameter("@MenuName",CafeMenuName ),
                new SqlParameter("@Result",SqlDbType.NVarChar,100){Direction=ParameterDirection.Output}
            };

            string result = dbHelper.ExecuteNonQuery("SP_USERMENUDELETE", CommandType.StoredProcedure, parameters);


            if (result == "T")
            {
                MessageBox.Show($"{CafeMenuName}를 삭제하셨습니다");
                LoadMenuList();
            }
            else
            {
                MessageBox.Show("삭제 실패");
            }
        }

        private void btnMenuBoxList_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            var menuInfo = (dynamic)clickedButton.Tag;

            string menuName = menuInfo.Name;
            string menuPrice = menuInfo.Price;

            SqlParameter[] parameters = {
                new SqlParameter("@Id", SessionId),
                new SqlParameter("@MenuName",menuName ),
                new SqlParameter("@MenuPrice", menuPrice),
                new SqlParameter("@Result",SqlDbType.NVarChar,100){Direction=ParameterDirection.Output}
            };

            string resultInsert = dbHelper.ExecuteNonQuery("SP_USERMENUINSERT", CommandType.StoredProcedure, parameters);

            if (resultInsert == "T")
            {
                MessageBox.Show($"{menuName}을 장바구니에 담았습니다");
                LoadMenuBoxData();
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void MenuPayment_Click(object sender, EventArgs e)
        {

            Console.WriteLine($"총금액 : {resultSS}   나의 금액 {userMoney} " );

            int TotalAmount = Convert.ToInt32(resultSS);

            if (userMoney < TotalAmount)
            {
                MessageBox.Show("잔액이 부족합니다");
                return; 
            }
            int TotalMoney = userMoney - TotalAmount;
            int TotalPayMoney = userPayMoney + TotalAmount;

            SqlParameter[] parameters = {
                new SqlParameter("@Id", SessionId),
                new SqlParameter("@TotalMoney",TotalMoney),
                new SqlParameter("@PayMoney",TotalPayMoney),
                new SqlParameter("@Result",SqlDbType.NVarChar,100){Direction=ParameterDirection.Output}
            };

            string resultInsert = dbHelper.ExecuteNonQuery("SP_MenuPayMent", CommandType.StoredProcedure, parameters);

            
            if (resultInsert == "T")
            {
                MessageBox.Show("결제가 성공적으로 되었습니다" + "   남은 잔액 : " + TotalMoney + "원 입니다.!!");
                Main form = new Main(SessionId);
                this.Hide();
                form.Show();
                return;
            }
            else if (resultInsert == "R")
            {
                MessageBox.Show("샷추가만 구매 불가합니다");
                return;
            }
            else
            {
                MessageBox.Show("error");
                return;
            }
        }
    }
}
