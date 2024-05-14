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
using static WindowsFormsApp3.Index;


namespace WindowsFormsApp3
{
    public partial class TodoListF : Form
    {
        private const string connectionString = "Server=DESKTOP-R04VI57\\MSSQLSERVER1;Database=master;Uid=sa;Pwd=1234";
        private readonly DBHelper dbHelper;

        private string SessionID;

        public TodoListF(string sessionID)
        {
            InitializeComponent();
            dbHelper = new DBHelper(connectionString);
            this.SessionID = sessionID;
            LoadTodoListData(SessionID);
            label1.Text = "ID :" + SessionID ;
        }

        private void Context_TextChanged(object sender, EventArgs e)
        {

        }

        //리스트 추가 로직
        private void ContextInput_Click(object sender, EventArgs e)
        {

            string contextData = Context.Text;

            SqlParameter[] parameters = {

                new SqlParameter("@Context", contextData),
                new SqlParameter("@Id", SessionID),
                new SqlParameter("@Result",SqlDbType.NVarChar,100){Direction=ParameterDirection.Output}
            };

            string result = dbHelper.ExecuteNonQuery("sp_ContextInsert", CommandType.StoredProcedure, parameters);

            if (result == "T")
            {
                LoadTodoListData(SessionID);
                return;
            }
        }
        //페이지가 로드 될때 가져오는 값
        private void LoadTodoListData(string SessionID)
        {
            DataTable dataTable = dbHelper.ExecuteDataTable("GetTodoListByUserId", CommandType.StoredProcedure, new SqlParameter("@Id", SessionID));
            listBoxTodo.DataSource = dataTable;
            listBoxTodo.DisplayMember = "context";

            // ListBox의 모든 컨트롤 제거 !
            listBoxTodo.Controls.Clear();

            //버튼만들기~!
            Button[] btnDelete = new Button[100];

            int buttonWidth = 100;
            int buttonHeight = 18;
            int buttonSpacingY = 0;

            for (int i = 0; i < listBoxTodo.Items.Count; i++)
            {
                DataRowView dataRowView = (DataRowView)listBoxTodo.Items[i];

                            
                string contextValue = dataRowView["context"].ToString();
                Console.WriteLine(contextValue+"데이터 로우 잘 들어와 ???????");

                btnDelete[i] = new Button();
                btnDelete[i].Text = "삭제";
                btnDelete[i].Tag = contextValue;

                btnDelete[i].Click += BtnDelete_Click;
                int buttonX = 400;

                int buttonY = -6 + i * (buttonHeight + buttonSpacingY);

                btnDelete[i].Location = new Point(buttonX, buttonY);
                btnDelete[i].Size = new Size(buttonWidth, buttonHeight);
                btnDelete[i].Font = new Font("굴림", 9);

                listBoxTodo.Controls.Add(btnDelete[i]);
            }
        }


        // 삭제 버튼 클릭 이벤트 처리
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Button btnDelete = (Button)sender;
            string contextValue = btnDelete.Tag.ToString();

             SqlParameter[] parameters = {

                new SqlParameter("@Context", contextValue),
                new SqlParameter("@Id", SessionID),
                new SqlParameter("@Result",SqlDbType.NVarChar,100){Direction=ParameterDirection.Output}
            };

            string resultInsert = dbHelper.ExecuteNonQuery("sp_ContextDelete", CommandType.StoredProcedure, parameters);

            if (resultInsert == "T")
            {
                MessageBox.Show("성공");
                LoadTodoListData(SessionID);
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "ID : " + SessionID;
        }
    }
}