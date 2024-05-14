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
    public partial class Highlow : Form
    {
        private string SessionId;
        private const string connectionString = "Server=DESKTOP-R04VI57\\MSSQLSERVER1;Database=model;Uid=sa;Pwd=1234";
        private readonly DBHelper dbHelper;
        int userMoney;
        int RandomNumSet;
        int opportunity = 1;
        int moneyInt;
        Label startNumLabel;
        Label lastNumLabel;
        int firstNum = 1;
        int lastNum = 100;

        public Highlow(string SessionId, int userMoney)
        {
            InitializeComponent();
            dbHelper = new DBHelper(connectionString);
            this.SessionId = SessionId;
            Random rand = new Random();
            int RandomNum = rand.Next(1, 101);
            RandomNumSet = RandomNum;
            this.userMoney = userMoney;
            userM.Text = userMoney + "원";
            startNumLabel = new Label();
            label1.Text = SessionId + " 하이로우 게임에 오신걸 환영합니다 ! 이기면 5배 !!"; 
        }

        private void moneyB_Click(object sender, EventArgs e)
        {
            string money = MoneyBox.Text.Trim();

            moneyInt = Convert.ToInt32(money);

            if (moneyInt > userMoney)
            {
                MessageBox.Show(SessionId + "님께서 가진 금액보다 많은 금액을 입력하셨습니다 ! ");
                return;
            }


            Label MoneyLabel = new Label();
            MoneyLabel.Text = money + "원";
            MoneyLabel.Location = moneyB.Location;
            MoneyLabel.Font = new Font("굴림", 16);


            this.Controls.Add(MoneyLabel);
            this.Controls.Remove(MoneyBox);
            this.Controls.Remove(moneyB);

            
            //lastNumLabel = new Label();


            startNumLabel.Text = firstNum + "~" + lastNum;
           // lastNumLabel.Text =" "+lastNum+" <범위"  ;

            startNumLabel.Location = new Point(330, 100);
            //lastNumLabel.Location = new Point(400, 85);


            startNumLabel.Font = new Font("굴림", 15);
         //   lastNumLabel.Font = new Font("굴림", 13);

            this.Controls.Add(startNumLabel);
           // this.Controls.Add(lastNumLabel);



            Button GameB = new Button();

            GameB = new Button();
            
            GameB.Text = "게임 GOGO ";


            GameB.Click += GameB_Click;
            int buttonX = 507;
            int buttonY = 150;

            GameB.Location = new Point(buttonX, buttonY);
            GameB.Size = new Size(130, 80);
            GameB.Font = new Font("굴림", 15);
            this.Controls.Add(GameB);

        }

        private void GameB_Click(object sender, EventArgs e)
        {
            string Num = NumInput.Text.Trim();
            int NumInt = Convert.ToInt32(Num);

            if (opportunity == 5)
            {

                int userTotalMoney = userMoney - moneyInt;

                SqlParameter[] parameters = {
                new SqlParameter("@Id", SessionId),
                new SqlParameter("@TotalMoney", userTotalMoney),
                new SqlParameter("@victory", "LOSE")

                 };

                string result = dbHelper.ExecuteScalar("SP_UserHighLowGame", CommandType.StoredProcedure, parameters);


                if (result == "L")
                {
                    MessageBox.Show("기회가 종료되었습니다" + "정답은 " + RandomNumSet + " 입니다.");
                }
                Random rand = new Random();
                int RandomNum = rand.Next(1, 101);
                this.RandomNumSet = RandomNum;

                Main form = new Main(SessionId);
                form.Show();
                this.Hide();
                return;
            }

            if (RandomNumSet == NumInt)
            {

                int userTotalMoney = userMoney + moneyInt*5;

                SqlParameter[] parameters = {
                new SqlParameter("@Id", SessionId),
                new SqlParameter("@TotalMoney", userTotalMoney),
                new SqlParameter("@victory", "WIN")

                 };

                string result=dbHelper.ExecuteScalar("SP_UserHighLowGame", CommandType.StoredProcedure, parameters);

                if (result == "T")
                {
                    MessageBox.Show(RandomNumSet + " 정답입니다");
                    opportunity = 1;
                    Main form = new Main(SessionId);
                    form.Show();
                    this.Hide();
                }
                return;

            }
            else if (RandomNumSet >= NumInt)
            {
                firstNum = NumInt;
                startNumLabel.Text = firstNum + " ~ " + lastNum;
                Console.WriteLine(lastNum + "   " + startNumLabel.Text);

                MessageBox.Show("UP" + opportunity + "번 기회가 남았습니다.");
                opportunity++;
                return;
            }
            else if (RandomNumSet < NumInt)
            {
                lastNum = NumInt;
                startNumLabel.Text = firstNum + " ~ " + lastNum;
                Console.WriteLine(lastNum);
                MessageBox.Show("DOWN" + opportunity + "번 기회가 남았습니다.");
                opportunity++;
                return;
            }
            else if (NumInt > 101)
            {
                MessageBox.Show("범위를 벗어났습닌다. " + opportunity + "번 기회가 남았습니다.");
                opportunity++;
                return;

            }
        }


    }
}
