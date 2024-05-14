using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FriendList : Form
    {
        private const string connectionString = "Server=DESKTOP-R04VI57\\MSSQLSERVER1;Database=master;Uid=sa;Pwd=1234";
        private readonly DBHelper dbHelper;
        private string SessionID;

        public FriendList(string sessionId)
        {
            InitializeComponent();
            dbHelper = new DBHelper(connectionString);
            SessionID = sessionId;
            LoginIdText.Text = "ID : " + SessionID;
            LoadFriendList();
            LoadRequestFriendList();
            LoadWaitRequestFriendList();
        }

        // 폼 완전 업로드
        private void ReloadForm()
        {
            this.Controls.Clear();
            InitializeComponent();
            LoginIdText.Text = "ID : " + SessionID;
            LoadFriendList();
            LoadRequestFriendList();
            LoadWaitRequestFriendList();
        }


        //요청중인 친구 불러오기 
        private void LoadRequestFriendList()
        {
            DataTable dataTable = dbHelper.ExecuteDataTable("sp_GetFriendListRequest", CommandType.StoredProcedure, new SqlParameter("@Id", SessionID), new SqlParameter("@Result", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output });
            RequestFriend.DataSource = dataTable;
            RequestFriend.DisplayMember = "FriendId";
            RequestFriend.SelectedIndex = RequestFriend.Items.Count - 1;
            RequestFriend.SelectedIndex = -1;

            //버튼만들기~!
            Button[] btnRequest = new Button[100];

            int buttonWidth = 100;
            int buttonHeight = 20;
            int buttonSpacingY = 0;
            string IdValue = "";
            DataRowView dataRowView = null;

            for (int i = 0; i < RequestFriend.Items.Count; i++)
            {
                dataRowView = (DataRowView)RequestFriend.Items[i];

                IdValue = dataRowView["FriendId"].ToString();

                if (!dataTable.Columns.Contains("FriendId"))
                {
                    IdValue = "";
                }
                else
                {
                    IdValue = dataRowView["FriendId"].ToString();
                }

                btnRequest[i] = new Button();
                btnRequest[i].Text = "요청중";
                btnRequest[i].Tag = IdValue;

                btnRequest[i].Click += btnRequest_Click;
                int buttonX = 400;

                int buttonY = -2 + i * (buttonHeight + buttonSpacingY);

                btnRequest[i].Location = new Point(buttonX, buttonY);
                btnRequest[i].Size = new Size(buttonWidth, buttonHeight);
                btnRequest[i].Font = new Font("Microsoft Sans Serif", 8);
                btnRequest[i].ForeColor = Color.Blue;
                btnRequest[i].BackColor = Color.SkyBlue;

                RequestFriend.Controls.Add(btnRequest[i]);
            }
        }

        // 친구요청 취소 
        private void btnRequest_Click(object sender, EventArgs e)
        {
            Button RequestCancelBtn = (Button)sender;
            string FriendId = RequestCancelBtn.Tag.ToString();

            SqlParameter[] parameters = {
                new SqlParameter("@friend", FriendId),
                new SqlParameter("@Id", SessionID),
                new SqlParameter("@Result",SqlDbType.NVarChar,100){Direction=ParameterDirection.Output}
            };

            string result = dbHelper.ExecuteNonQuery("sp_FriendListRequestCancel", CommandType.StoredProcedure, parameters);

            if (result == "T")
            {
                MessageBox.Show("요청이 취소 되었습니다.");
                ReloadForm();
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        // 친구 대기 Listbox 
        private void LoadWaitRequestFriendList()
        {

            DataTable dataTable = dbHelper.ExecuteDataTable("sp_GetFriendWaitRequest", CommandType.StoredProcedure, new SqlParameter("@Id", SessionID));
            WaitRequest.DataSource = dataTable;
            WaitRequest.DisplayMember = "userId";


            int buttonWidth = 70;
            int buttonHeight = 21;
            int buttonSpacingY = 0;
            string IdValue = "";
            DataRowView dataRowView = null;

            for (int i = 0; i < WaitRequest.Items.Count; i++)
            {

                dataRowView = (DataRowView)WaitRequest.Items[i];

                if (!dataTable.Columns.Contains("userId"))
                {
                    IdValue = "";
                }
                else
                {
                    IdValue = dataRowView["userId"].ToString();
                }
                //버튼만들기~!
                Button[] btnAccept = new Button[100];

                btnAccept[i] = new Button();
                btnAccept[i].Text = "수락";
                btnAccept[i].Tag = IdValue;

                btnAccept[i].Click += btnAccept_Click;
                int buttonX = 400;

                int buttonY = -4 + i * (buttonHeight + buttonSpacingY);

                btnAccept[i].Location = new Point(buttonX, buttonY);
                btnAccept[i].Size = new Size(buttonWidth, buttonHeight);
                btnAccept[i].Font = new Font("Microsoft Sans Serif", 8);
                btnAccept[i].ForeColor = Color.Blue;
                btnAccept[i].BackColor = Color.SkyBlue;

                WaitRequest.Controls.Add(btnAccept[i]);

            }
            for (int i = 0; i < WaitRequest.Items.Count; i++)
            {
                dataRowView = (DataRowView)WaitRequest.Items[i];

                if (!dataTable.Columns.Contains("userId"))
                {
                    IdValue = "";
                }
                else
                {
                    IdValue = dataRowView["userId"].ToString();
                }
                //버튼만들기~!
                Button[] btnRefuse = new Button[100];
                btnRefuse[i] = new Button();
                btnRefuse[i].Text = "거절";
                btnRefuse[i].Tag = IdValue;

                btnRefuse[i].Click += btnRefuse_Click;
                int buttonX = 468;

                int buttonY = -4 + i * (buttonHeight + buttonSpacingY);

                btnRefuse[i].Location = new Point(buttonX, buttonY);
                btnRefuse[i].Size = new Size(buttonWidth, buttonHeight);
                btnRefuse[i].Font = new Font("Microsoft Sans Serif", 8);
                btnRefuse[i].ForeColor = Color.Blue;
                btnRefuse[i].BackColor = Color.SkyBlue;

                WaitRequest.Controls.Add(btnRefuse[i]);
            }
        }

        // 친구 추가 버튼(수락 버튼)
        private void btnAccept_Click(object sender, EventArgs e)
        {
            Button AddBtn = (Button)sender;
            string userId = AddBtn.Tag.ToString();

            SqlParameter[] parameters = {
                new SqlParameter("@friend", userId),
                new SqlParameter("@Id", SessionID),
                new SqlParameter("@Result",SqlDbType.NVarChar,100){Direction=ParameterDirection.Output}
            };

            string resultInsert = dbHelper.ExecuteNonQuery("sp_FriendListAdd", CommandType.StoredProcedure, parameters);

            if (resultInsert == "T")
            {
                MessageBox.Show($"{userId}님과 친구가 되었습니다");
                ReloadForm();
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        // 친구요청 거절 버튼
        private void btnRefuse_Click(object sender, EventArgs e)
        {
            Button RefuseBtn = (Button)sender;
            string friend = RefuseBtn.Tag.ToString();

            SqlParameter[] parameters = {
                new SqlParameter("@friend", friend),
                new SqlParameter("@Id", SessionID),
                new SqlParameter("@Result",SqlDbType.NVarChar,100){Direction=ParameterDirection.Output}
            };

            string result = dbHelper.ExecuteNonQuery("sp_FriendListRefuse", CommandType.StoredProcedure, parameters);

            if (result == "T")
            {
                MessageBox.Show("친구를 거절하였습니다.");
                ReloadForm();
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        // 윈폼이 시작했을때 친구 리스트 불러오기 
        private void LoadFriendList()
        {
            DataTable dataTable = dbHelper.ExecuteDataTable("sp_GetFriendList", CommandType.StoredProcedure, new SqlParameter("@Id", SessionID), new SqlParameter("@Result", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output });
            FriendListBox.DataSource = dataTable;
            FriendListBox.DisplayMember = "FriendId";
            FriendListBox.DisplayMember = "UserId";
           
            int buttonWidth = 90;
            int buttonHeight = 20;
            int buttonSpacingY = 0;
            string IdValue = "";
            DataRowView dataRowView = null;

            for (int i = 0; i < FriendListBox.Items.Count; i++)
            {
                dataRowView = (DataRowView)FriendListBox.Items[i];

                if (!dataTable.Columns.Contains("FriendId"))
                {
                    IdValue = dataRowView["UserId"].ToString();
                }
                else
                {
                    IdValue = dataRowView["FriendId"].ToString();
                }

                //버튼만들기~!
                Button[] btnChat = new Button[100];

                btnChat[i] = new Button();
                btnChat[i].Text = "채팅 하기";
                btnChat[i].Tag = IdValue;

                btnChat[i].Click += btnChat_Click;
                int buttonX = 350;

                int buttonY = -1 + i * (buttonHeight + buttonSpacingY);

                btnChat[i].Location = new Point(buttonX, buttonY);
                btnChat[i].Size = new Size(buttonWidth, buttonHeight);
                btnChat[i].Font = new Font("Microsoft Sans Serif", 8);
                btnChat[i].ForeColor = Color.Blue;
                btnChat[i].BackColor = Color.SkyBlue;

                FriendListBox.Controls.Add(btnChat[i]);
            }

            for (int i = 0; i < FriendListBox.Items.Count; i++)
            {
                dataRowView = (DataRowView)FriendListBox.Items[i];

                if (!dataTable.Columns.Contains("FriendId"))
                {
                    IdValue = dataRowView["UserId"].ToString();
                }
                else
                {
                    IdValue = dataRowView["FriendId"].ToString();
                }

                //버튼만들기~!
                Button[] btnFriendDelete = new Button[100];

                btnFriendDelete[i] = new Button();
                btnFriendDelete[i].Text = "친구 삭제";
                btnFriendDelete[i].Tag = IdValue;

                btnFriendDelete[i].Click += btnFriendDelete_Click;
                int buttonX = 443;

                int buttonY = -1 + i * (buttonHeight + buttonSpacingY);

                btnFriendDelete[i].Location = new Point(buttonX, buttonY);
                btnFriendDelete[i].Size = new Size(buttonWidth, buttonHeight);
                btnFriendDelete[i].Font = new Font("Microsoft Sans Serif", 8);
                btnFriendDelete[i].ForeColor = Color.Blue;
                btnFriendDelete[i].BackColor = Color.SkyBlue;

                FriendListBox.Controls.Add(btnFriendDelete[i]);
            }
        }

        //친구 삭제 버튼
        private void btnFriendDelete_Click(object sender, EventArgs e)
        {
            Button FriendDeleteBtn = (Button)sender;
            string friend = FriendDeleteBtn.Tag.ToString();

            SqlParameter[] parameters = {
                new SqlParameter("@friend", friend),
                new SqlParameter("@Id", SessionID),
                new SqlParameter("@Result",SqlDbType.NVarChar,100){Direction=ParameterDirection.Output}
            };
            string result = dbHelper.ExecuteNonQuery("sp_FriendListDelete", CommandType.StoredProcedure, parameters);

            if (result == "T")
            {
                MessageBox.Show("친구 삭제 완료되었습니다.");
                ReloadForm();
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        // 친구와 채팅하로 가기
        private void btnChat_Click(object sender, EventArgs e)
        {
            Button chatBtn = (Button)sender;
            string chatId = chatBtn.Tag.ToString();

            ChatForm chat = new ChatForm(chatId, SessionID);
            chat.Show();
        }

        // 친구 검색 
        private void FriendFindBtn_Click(object sender, EventArgs e)
        {
            string friend = FriendFind.Text.Trim();

            if (string.IsNullOrWhiteSpace(friend))
            {
                MessageBox.Show("아이디를 입력해주세요");
                return;
            }
            else if (SessionID == friend)
            {
                MessageBox.Show("회원님 아이디와 동일합니다.");
                return;
            }

            SqlParameter[] parameters = { new SqlParameter("@Id", friend) };

            string result = dbHelper.ExecuteScalar("sp_FriendIdCheck", CommandType.StoredProcedure, parameters);

            if (result == "T")
            {

                if (MessageBox.Show(friend + "> 친구 요청을 보내시겠습니까 ?", "친구요청", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    RequestFriendSend(friend);
                }
                else 
                {
                    MessageBox.Show("친구요청이 취소되었습니다");
                }
            }
            else
            {
                MessageBox.Show("존재하지 않는 아이디 입니다.");
            }
        }

        // 친구 요청 보내기 
        private void RequestFriendSend(string friendId)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@friend", friendId),
                new SqlParameter("@Id", SessionID),
                new SqlParameter("@Result",SqlDbType.NVarChar,100){Direction=ParameterDirection.Output}
            };

            string result = dbHelper.ExecuteNonQuery("sp_FriendListRequest", CommandType.StoredProcedure, parameters);

            if (result == "T")
            {
                MessageBox.Show($"{friendId}님에게 친구요청이 완료 되었습니다.");
                ReloadForm();
            }
            else
            {
                MessageBox.Show($"{friendId}가 이미 요청중인 친구입니다.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FriendListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
