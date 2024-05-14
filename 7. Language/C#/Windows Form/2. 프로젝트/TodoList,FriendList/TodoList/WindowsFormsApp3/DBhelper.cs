using System;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public class DBHelper
    {
        private readonly string connectionString;

        public DBHelper(string connectionString)
        {
            this.connectionString = connectionString;
        }


        public string ExecuteScalar(string query, CommandType commandType, SqlParameter[] parameters)
        {
            Console.WriteLine(parameters.Length + "잘들어오고 있어ㅏ ?????");
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

                    command.ExecuteScalar();

                    Console.WriteLine(Convert.ToString(command.Parameters["@Result"].Value) + "어떻게 들어오고있니??");

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
            Console.WriteLine(parameters.Length + "잘들어오고 있어ㅏ ?????");
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