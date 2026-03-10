using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK_DataAccess
{
    public static class clsUserData
    {
        public static DataTable GetAllUsers()
        {
            DataTable result = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
                {
                    connection.Open();
                    string Query = "select Users.UserId,Users.PersonId,People.FirstName+' '+People.LastName as FullName,Users.Role,Users.UserName,Users.Status from Users INNER JOIN People ON People.PersonId=Users.PersonId order by  Users.UserId desc;;";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                result.Load(reader);
                            }

                        }
                    }


                }
            }
            catch (SqlException ex)
            {
                clsLogger.WriteLog(ex.Message);
            }
            return result;
        }

        public static bool FindUser(int UserId,ref string Status, ref int Permissions, ref int PersonId, ref string UserName, ref string Password,ref string Role)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
                {
                    connection.Open();
                    string Query = "select * from Users where UserId=@UserId";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", UserId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;
                                Status = Convert.ToByte(reader["Status"]) == 0 ? "Closed":"Active";
                                Permissions = Convert.ToInt32(reader["Permissions"]);
                                PersonId = Convert.ToInt32(reader["PersonId"]);
                                UserName = reader["UserName"].ToString();
                                Password = reader["Password"].ToString();
                                Role = reader["Role"].ToString();
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                clsLogger.WriteLog(ex.Message);
            }
            return IsFound;
        }

        public static bool FindUser(ref int UserId,ref string Status, ref int Permissions, ref int PersonId,  string UserName,ref  string Password,ref string Role)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
                {
                    connection.Open();
                    string Query = "select * from Users where UserName=@UserName";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@UserName", UserName);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;
                                Status = Convert.ToByte(reader["Status"]) == 0 ? "Closed" : "Active";
                                Permissions = Convert.ToInt32(reader["Permissions"]);
                                PersonId = Convert.ToInt32(reader["PersonId"]);
                                UserId = Convert.ToInt32(reader["UserId"]);
                                Password = reader["Password"].ToString();
                                Role = reader["Role"].ToString();
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                clsLogger.WriteLog(ex.Message);
            }
            return IsFound;
        }

        public static bool FindUser(ref int UserId,ref string Status, ref int Permissions, ref int PersonId, string UserName,  string Password, ref string Role)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
                {
                    connection.Open();
                    string Query = "select * from Users where UserName=@UserName and Password=@Password";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@UserName", UserName);
                        command.Parameters.AddWithValue("@Password", Password);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;
                                Status = Convert.ToByte(reader["Status"]) == 0 ? "Closed" : "Active";
                                Permissions = Convert.ToInt32(reader["Permissions"]);
                                PersonId = Convert.ToInt32(reader["PersonId"]);
                                UserId = Convert.ToInt32(reader["UserId"]);
                                Role = reader["Role"].ToString();
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                clsLogger.WriteLog(ex.Message);
            }
            return IsFound;
        }

        public static bool IsExist(string UserName)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
                {
                    connection.Open();
                    string Query = "select * from Users where UserName=@UserName";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@UserName", UserName);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.WriteLog(ex.Message);
            }
            return IsFound;
        }
        public static bool IsExist(int UserId)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
                {
                    connection.Open();
                    string Query = "select * from Users where UserId=@UserId";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", UserId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                clsLogger.WriteLog(ex.Message);
            }
            return IsFound;
        }

        public static bool IsUserExistByPersonId(int PersonId)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
                {
                    connection.Open();
                    string Query = "select * from Users where PersonId=@PersonId";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonId", PersonId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                clsLogger.WriteLog(ex.Message);
            }
            return IsFound;
        }

        public static int AddUser(string Status,  int Permissions,  int PersonId, string UserName, string Password,string Role)
        {
            int UserId = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
                {
                    connection.Open();
                    string Query = "insert into Users values (@Status,@Permissions,@PersonId,@UserName,@Password,@Role);select SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@Status", Status == "Closed"?0:1);
                        command.Parameters.AddWithValue("@Permissions", Permissions);
                        command.Parameters.AddWithValue("@PersonId", PersonId);
                        command.Parameters.AddWithValue("@UserName", UserName);
                        command.Parameters.AddWithValue("@Password", Password);
                        command.Parameters.AddWithValue("@Role", Role);

                        object Result = command.ExecuteScalar();
                        if (Result != null && int.TryParse(Result.ToString(), out int Id))
                        {
                            UserId = Id;
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                clsLogger.WriteLog(ex.Message);
            }
            return UserId;
        }

        public static bool UpdateUser(int UserId,string Status, int Permissions, int PersonId, string UserName, string Password, string Role)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
                {
                    connection.Open();
                    string Query = "update Users set Status=@Status,Permissions=@Permissions,PersonId=@PersonId,UserName=@UserName,Password=@Password,Role=@Role where UserId=@UserId";
                    using (SqlCommand cmd = new SqlCommand(Query, connection))
                    {
                        cmd.Parameters.AddWithValue("@UserId", UserId);
                        cmd.Parameters.AddWithValue("@Status", Status == "Closed"?0:1);
                        cmd.Parameters.AddWithValue("@Permissions", Permissions);
                        cmd.Parameters.AddWithValue("@UserName", UserName);
                        cmd.Parameters.AddWithValue("@Password", Password);
                        cmd.Parameters.AddWithValue("@PersonId", PersonId);
                        cmd.Parameters.AddWithValue("@Role", Role);
                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.WriteLog(ex.Message);
            }
            return rowsAffected != 0;
        }

        public static bool ChangePassword(int UserId,string Password)
        {

            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
                {
                    connection.Open();
                    string Query = "update Users set Password=@Password where UserId=@UserId";
                    using (SqlCommand cmd = new SqlCommand(Query, connection))
                    {
                        cmd.Parameters.AddWithValue("@UserId", UserId);
                       
                        cmd.Parameters.AddWithValue("@Password", Password);
                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.WriteLog(ex.Message);
            }
            return rowsAffected != 0;
        }
        public static bool DeleteUser(int UserId)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
                {
                    connection.Open();
                    string Query = "delete from Users where UserId=@UserId";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", UserId);
                        rowsAffected = command.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception ex)
            {
                clsLogger.WriteLog(ex.Message);
            }
            return rowsAffected != 0;
        }
    }
}



