using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp3.LoginForm;

namespace WindowsFormsApp3
{
    public partial class Index : Form
    {
        private const string connectionString = "Server=DESKTOP-R04VI57\\MSSQLSERVER1;Database=master;Uid=sa;Pwd=1234";
        private readonly DBHelper dbHelper;
        private string profilePicturePath; // 프로필 사진 파일 경로 저장 변수
        private string SessionID;

        public Index(string sessionID)
        {
            InitializeComponent();
            dbHelper = new DBHelper(connectionString);
            SessionID = sessionID;
            label1.Text = "ID : " + SessionID;
            LoadProfileData(SessionID);
        }

        private void Index_Load(object sender, EventArgs e)
        {


        }


        private void ChangeProfilePicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // 선택된 파일의 경로를 얻어옴
                    profilePicturePath = openFileDialog.FileName;

                    // 폼 디자이너에서 추가한 pictureBoxProfile에 이미지 로드
                    pictureBoxProfile.Image = Image.FromFile(profilePicturePath);
                }
            }
        }

        private void SaveProfilePicture_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(profilePicturePath))
            {

                // 프로필 사진 파일을 읽어와 바이트 배열로 변환
                byte[] profilePictureBytes = File.ReadAllBytes(profilePicturePath);

                SqlParameter[] parameters = {

                    new SqlParameter("@UserId", SessionID),
                    new SqlParameter("@ProfilePicture", profilePictureBytes),
                    new SqlParameter("@Result",SqlDbType.NVarChar,100){Direction=ParameterDirection.Output}
                };

                string result = dbHelper.ExecuteNonQuery("sp_SaveProfilePicture", CommandType.StoredProcedure, parameters);

                Console.WriteLine(result + "사진 잘 들어와 ??");

                if (result == "T")
                {
                    MessageBox.Show("프로필 사진이 저장되었습니다.");
                }
                else
                {
                    MessageBox.Show("프로필 사진 저장에 실패했습니다.");
                }
            }
            else
            {
                MessageBox.Show("프로필 사진을 선택하세요.");
            }
        }

        private void LoadProfileData(string SessionID)
        {
            Console.WriteLine(SessionID + "id값 잘 들어와 ???");

            SqlParameter[] parameters =
             {
                 new SqlParameter("@Id", SessionID),
                 new SqlParameter("@Result", SqlDbType.VarBinary, -1) { Direction = ParameterDirection.Output }

             };

            byte[] result = dbHelper.ExecuteScalar2("sp_LoadProfile", CommandType.StoredProcedure, parameters);

            // 프로시저에서 반환한 프로필 사진 바이트 배열
            // byte[] profilePictureBytes = parameters[1].Value as byte[];
            // Console.WriteLine("Result from ExecuteScalar: " + result);
            // Console.WriteLine("Result from profilePictureBytes: " + profilePictureBytes);


            if (result != null && result.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(result))
                {
                    pictureBoxProfile.Image = Image.FromStream(ms);
                }
            }
            else
            {
                Console.WriteLine("프로필 사진이 없음 ");
                pictureBoxProfile.Image = null;
            }
        }

        private void FriendListPage_Click(object sender, EventArgs e)
        {
            FriendList friend = new FriendList(SessionID);
            friend.Show();
        }

        private void todolist_Click_1(object sender, EventArgs e)
        {
            TodoListF todolistFrom = new TodoListF(SessionID);
            todolistFrom.Show();
        }

        private void logout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
