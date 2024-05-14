using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace test
{
    public class DBHelper
    {
        private readonly string connectionString;

        public DBHelper(string connectionString)
        {
            this.connectionString = connectionString;
        }




        public int ExecuteReader(string query, CommandType commandType, SqlParameter[] parameters)
        {
            int dataString = 0;
            int sum = 0;
            
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = commandType;

                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    command.Parameters.Add(new SqlParameter("@Result", SqlDbType.NVarChar, 500) { Direction = ParameterDirection.Output });

                    connection.Open();

                    SqlDataReader rd=command.ExecuteReader();

                    while (rd.Read())
                    {
                        dataString = Convert.ToInt32(rd["CafeMenuPrice"].ToString());

                        sum += dataString;
                    }

                    return sum;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return 0;
            }
        }



        public List<string> ExecuteReaderList(string query, CommandType commandType, SqlParameter[] parameters)
        {
            List<string> userInfo = new List<string>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = commandType;

                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }


                    connection.Open();

                    SqlDataReader rd = command.ExecuteReader();

                    rd.Read();

                    userInfo.Add(rd["userId"].ToString());
                    userInfo.Add(rd["userName"].ToString());
                    userInfo.Add(rd["userLock"].ToString());

                    return userInfo;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return userInfo;

            }
        }





        public string ExecuteScalar(string query, CommandType commandType, SqlParameter[] parameters)
        {
            Console.WriteLine("1번");
            try
            {
                Console.WriteLine("2번");
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = commandType;

                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    command.Parameters.Add(new SqlParameter("@Result", SqlDbType.NVarChar, 500) { Direction = ParameterDirection.Output });

                    connection.Open();

                    command.ExecuteScalar();

                    Console.WriteLine(Convert.ToString(command.Parameters["@Result"].Value) + "데이터베이스 받는 데이엍");

                    return Convert.ToString(command.Parameters["@Result"].Value);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return "error";
            }
        }


        public byte[] ExecuteScalar2(string query, CommandType commandType, SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = commandType;

                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    connection.Open();
                    command.ExecuteScalar();

                    // @Result 매개변수의 값을 바이트 배열로 반환
                    return command.Parameters["@Result"].Value as byte[];
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null; // 에러 발생 시 null 반환
            }
        }

        public DataTable ExecuteDataTable(string query, CommandType commandType, params SqlParameter[] parameters)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = commandType;
                    command.Parameters.AddRange(parameters);

                    try
                    {
                        connection.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            return dataTable;
        }


        public string ExecuteNonQuery(string query, CommandType commandType, SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = commandType;

                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    connection.Open();
                    command.ExecuteNonQuery();
                    command.Parameters.Add(new SqlParameter("@Result", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output });

                    return Convert.ToString(command.Parameters["@Result"].Value);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return "error";
            }
        }
    }
}