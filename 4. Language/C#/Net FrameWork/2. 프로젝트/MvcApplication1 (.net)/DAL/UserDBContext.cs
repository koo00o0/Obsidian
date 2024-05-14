using MvcApplication1.Models;
using System.Data.SqlClient;
using System.Diagnostics;

namespace MvcApplication1.DAL
{
    public class UserDBContext : IDisposable
    {
        private SqlDataReader dr;
        private readonly SqlConnection connection;
        private readonly string connectionString = "Server=DESKTOP-E7AGL3I\\MSSQLSERVER1; Database=master;User Id=sa; Password=1234;";

        public UserDBContext()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public void Dispose()
        {
            if (connection != null)
            {
                connection.Close();
                connection.Dispose();
            }
        }

        // 회원가입 insert
        public void UserRegister(User user)
        {
            Debug.WriteLine("여기는 들어왔어???");
            string query = "INSERT INTO User_yj VALUES (@UserId, @UserPw, @UserName)";
            Debug.WriteLine(query);

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", user.UserId);
                    command.Parameters.AddWithValue("@UserPw", user.UserPw);
                    command.Parameters.AddWithValue("@UserName", user.UserName);

                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine("데이터베이스 연결 오류: " + ex.Message);
            }
        }

        // 회원가입 select (아이디 중복체크)
        public string UserRegisterIdcheck(string id)
        {
            string query = "SELECT  * FROM User_yj WHERE userId=@userId ";
            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@userId", id);

                    dr = command.ExecuteReader();

                    while (dr.Read())
                    {
                        string userIdCheck = dr["userId"] as string;
                        if (id == userIdCheck)
                        {
                            return "F";
                        }
                        else
                        {
                            return "T";
                        }

                    }
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine("데이터베이스 연결 오류: " + ex.Message);     
            }
            return "E";
        }

        // 로그인
        public bool Login(User user)
        {
            Console.WriteLine("로그인 잘들어와 ???" + "id : " + user.UserId + " pw :" + user.UserPw);
            string query = "SELECT  * FROM User_yj WHERE userId=@userId AND userPw=@userPw";

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@userId", user.UserId);
                    command.Parameters.AddWithValue("@userPw", user.UserPw);

                    dr = command.ExecuteReader();

                    if (dr.Read())
                    {
                        Console.WriteLine(dr.Read());
                        
                            return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine("데이터베이스 연결 오류: " + ex.Message);
            }
            return false;
        }

        //로그인시 화면
        public List<string> Index()
        {
            List<string> userNames = new List<string>();
            string query = "SELECT  UserName FROM User_yj";
            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    Console.WriteLine(command + "어디야 ㅋㅋㅋ");
                    dr = command.ExecuteReader();

                    while (dr.Read())
                    {
                        userNames.Add(dr["UserName"].ToString());                    
                    }
                    return userNames;
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine("데이터베이스 연결 오류: " + ex.Message);
            }
            return userNames;

        }

        //유저의 투두리스트 
        public List<string> UserTodoList(string userId)
        {
            List<string> Contexts = new List<string>();
            string query = "SELECT  Context FROM userContext WHERE userId=@userId ";
            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);
                    dr = command.ExecuteReader();

                    while (dr.Read())
                    {
                        Contexts.Add(dr["Context"].ToString());
                    }
                    return Contexts;
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine("데이터베이스 연결 오류: " + ex.Message);
            }
            return Contexts;
        }

        //투두리스트 추가
        public string addContext(string context,string userId)
        {
            Debug.WriteLine("여기는 들어왔어???");
            string query = "INSERT INTO UserContext VALUES (@UserId, @Context)";
            Debug.WriteLine(query);

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.Parameters.AddWithValue("@Context", context);

                    command.ExecuteNonQuery();
                    return "T";
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine("데이터베이스 연결 오류: " + ex.Message);
            }
            return "F";

        }

        //투두리스트 삭제
        public string DeleteContext(string decontext, string userId)
        {
            Debug.WriteLine("여기는 들어왔어???");
            string query = "DELETE FROM UserContext WHERE  userId=@userId AND context=@decontext";
            Console.WriteLine(query);
            Debug.WriteLine(query);

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);
                    command.Parameters.AddWithValue("@decontext", decontext);
                    Console.WriteLine(command);
                    command.ExecuteNonQuery();
                    return "T";
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine("데이터베이스 연결 오류: " + ex.Message);
            }
            return "F";
        }

        
    }
}