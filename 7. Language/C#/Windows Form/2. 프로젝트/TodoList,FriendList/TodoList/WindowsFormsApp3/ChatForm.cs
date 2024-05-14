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

namespace WindowsFormsApp3
{
    public partial class ChatForm : Form
    {
        private const string connectionString = "Server=DESKTOP-R04VI57\\MSSQLSERVER1;Database=master;Uid=sa;Pwd=1234";
        private readonly DBHelper dbHelper;
        private string ChatId;
        private string SessionId;
        private Timer messageTimer;
        public ChatForm(string ChatId,string SessionID)
        {
            InitializeComponent();
            dbHelper = new DBHelper(connectionString);
            this.ChatId = ChatId;
            this.SessionId = SessionID;
            label2.Text = "내 ID : " + SessionId;
            label3.Text = "상대방 ID : " + ChatId;
            LoadChattingListData(SessionId, ChatId);
            messageTimer = new Timer();
            messageTimer.Interval = 2000;
            messageTimer.Tick += new EventHandler(messageTimer_Tick);
            messageTimer.Start(); 
        }

        private void messageTimer_Tick(object sender, EventArgs e)
        {
            // 타이머 이벤트 발생 시 실행되는 메서드
            CheckForNewMessages();
        }

        private void CheckForNewMessages()
        {
            LoadChattingListData(SessionId, ChatId);
        }


        private void ChatBtn_Click(object sender, EventArgs e)
        {

            string ChatData = "ID " + "("+SessionId+") : "+ChatText.Text;

            SqlParameter[] parameters = {

                new SqlParameter("@Context", ChatData),
                new SqlParameter("@ChatId", ChatId),
                new SqlParameter("@Id", SessionId),
                new SqlParameter("@Result",SqlDbType.NVarChar,100){Direction=ParameterDirection.Output}
            };

            string result = dbHelper.ExecuteNonQuery("sp_ChatInsert", CommandType.StoredProcedure, parameters);

            if (result == "T")
            {
                LoadChattingListData(SessionId,ChatId);
                ChatText.Clear();
                this.ActiveControl = ChatText;
                return;
            }
        }

        private void ChatBtn_KeyDown(object sender, KeyEventArgs e)
        
        {
            string ChatData = "ID " + "(" + SessionId + ") : " + ChatText.Text;

            if (ChatText.Text.Trim() != "" && e.KeyCode == Keys.Enter)
            {


                SqlParameter[] parameters = {

                new SqlParameter("@Context", ChatData),
                new SqlParameter("@ChatId", ChatId),
                new SqlParameter("@Id", SessionId),
                new SqlParameter("@Result",SqlDbType.NVarChar,100){Direction=ParameterDirection.Output}
            };

                string result = dbHelper.ExecuteNonQuery("sp_ChatInsert", CommandType.StoredProcedure, parameters);

                if (result == "T")
                {
                    LoadChattingListData(SessionId, ChatId);
                    ChatText.Clear();
                    this.ActiveControl = ChatText;
                    return;
                }
            }

        }

        private void LoadChattingListData(string sessionId, string chatId)
        {
            DataTable dataTable = dbHelper.ExecuteDataTable("sp_GetChattingList", CommandType.StoredProcedure,
                new SqlParameter("@Id", SessionId) ,new SqlParameter("@ChatId", ChatId));

            ChatListBox.DataSource = dataTable;
            ChatListBox.DisplayMember = "context";
        }


        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadChattingListData(SessionId, ChatId);
            this.Hide();
            messageTimer.Stop();
        }
    }
}
