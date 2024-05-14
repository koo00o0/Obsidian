using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MvcApplication1.Models;
using System.Diagnostics;

namespace MvcApplication1.DAL
{
    public class UserDBContext : IDisposable
    {

        private SqlConnection connection;


        public UserDBContext()
        {
            // 데이터베이스 연결 문자열 가져오기
            string connectionString = ConfigurationManager.ConnectionStrings["ApplicationServices"].ConnectionString;
            Debug.WriteLine(connectionString + "fasfasfsaf");
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
            }
        }

        // IDisposable 인터페이스의 구현
        public void Dispose()
        {

            if (connection != null)
            {
                connection.Close();
                connection.Dispose();
            }
        }

        public void UserRegister(User user)
        {
            Debug.WriteLine("여기는 들어왔어???");
            // 사용자 등록을 위한 SQL 쿼리 작성
            string query = "INSERT INTO Users_yj VALUES (@UserId, @UserPw, @UserName)";

            // SqlCommand를 사용하여 쿼리 실행
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@UserId", user.UserId);
                command.Parameters.AddWithValue("@UserPw", user.UserPw);
                command.Parameters.AddWithValue("@UserName", user.UserName);

                command.ExecuteNonQuery();
            }
        }
    }
}