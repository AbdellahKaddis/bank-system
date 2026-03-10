using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Diagnostics;

namespace BANK_DataAccess
{
    static public class clsPersonData
    {
        public static DataTable GetAllPeople()
        {
            DataTable result = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
                {
                    connection.Open();
                    string Query = "select * from People order by PersonId desc;";
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

        public static bool FindPerson(ref int PersonId,string NationalNumber, ref string FirstName, ref string LastName, ref string Gender, ref DateTime DateOfBirth, ref string Address, ref string Phone, ref string Email)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
                {
                    connection.Open();
                    string Query = "select * from People where NationalNumber=@NationalNumber";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@NationalNumber", NationalNumber);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;
                                PersonId = Convert.ToInt32(reader["PersonId"]);
                                FirstName = reader["FirstName"].ToString();
                                LastName = reader["LastName"].ToString();
                                Gender = Convert.ToString(reader["Gender"]) == "f" ? "Female" : "Male";
                                DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                                Address = reader["Address"].ToString();
                                Phone = reader["Phone"].ToString();
                                if (reader["Email"] == System.DBNull.Value)
                                    Email = null;
                                else
                                    Email = reader["Email"].ToString();
                            }
                        }
                    }

                }
            }
            catch(Exception ex)
            {
                clsLogger.WriteLog(ex.Message);
            }
            return IsFound;
        }

        public static bool FindPerson(int PersonId,ref string NationalNumber, ref string FirstName, ref string LastName, ref string Gender, ref DateTime DateOfBirth, ref string Address, ref string Phone, ref string Email)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
                {
                    connection.Open();
                    string Query = "select * from People where PersonId=@PersonId";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonId", PersonId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;
                                NationalNumber = reader["NationalNumber"].ToString();
                                FirstName = reader["FirstName"].ToString();
                                LastName = reader["LastName"].ToString();
                                Gender = Convert.ToString(reader["Gender"]) == "f" ? "Female" : "Male";
                                DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                                Address = reader["Address"].ToString();
                                Phone = reader["Phone"].ToString();
                                if (reader["Email"] == System.DBNull.Value)
                                    Email = null;
                                else
                                    Email = reader["Email"].ToString();

                            }
                        }
                    }

                }
            }
              catch(Exception ex)
            {
                clsLogger.WriteLog(ex.Message);
            }
            return IsFound;
        }

        public static bool IsExist(string NationalNumber)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
                {
                    connection.Open();
                    string Query = "select * from People where NationalNumber=@NationalNumber";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@NationalNumber", NationalNumber);
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
        public static bool IsExist(int PersonId)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
                {
                    connection.Open();
                    string Query = "select * from People where PersonId=@PersonId";
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
             catch(Exception ex)
            {
                clsLogger.WriteLog(ex.Message);
            }
            return IsFound;
        }

        public static int AddPerson(string NationalNumber, string FirstName, string LastName, string Gender, DateTime DateOfBirth, string Address, string Phone, string Email)
        {
            int PersonId = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
                {
                    connection.Open();
                    string Query = "insert into People values (@NationalNumber,@FirstName,@LastName,@Gender,@DateOfBirth,@Address,@Phone,@Email);select SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@NationalNumber", NationalNumber);
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@LastName", LastName);

                        command.Parameters.AddWithValue("@Gender", Gender == "Male" ? "m":"f");
                        command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                        command.Parameters.AddWithValue("@Address", Address);
                        command.Parameters.AddWithValue("@Phone", Phone);

                        if(Email == null)
                            command.Parameters.AddWithValue("@Email", System.DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@Email", Email);

                        object Result = command.ExecuteScalar();
                        if (Result != null && int.TryParse(Result.ToString(), out int Id))
                        {
                            PersonId = Id;
                        }

                    }

                }
            }
          catch(Exception ex)
            {
                clsLogger.WriteLog(ex.Message);
            }
            return PersonId;
        }

        public static bool Update(int PersonId,string NationalNumber,string FirstName, string LastName, string Gender, DateTime DateOfBirth, string Address, string Phone, string Email)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
                {
                    connection.Open();
                    string Query = "UPDATE People set NationalNumber=@NationalNumber,FirstName=@FirstName,LastName=@LastName,Gender=@Gender,DateOfBirth=@DateOfBirth,Address=@Address,Phone=@Phone,Email=@Email where PersonId=@PersonId";
                    using (SqlCommand cmd = new SqlCommand(Query, connection))
                    {
                        cmd.Parameters.AddWithValue("@NationalNumber", NationalNumber);
                        cmd.Parameters.AddWithValue("@FirstName", FirstName);
                        cmd.Parameters.AddWithValue("@LastName", LastName);
                        cmd.Parameters.AddWithValue("@Gender", Gender == "Male"?"m":"f");
                        cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                        cmd.Parameters.AddWithValue("@Address", Address);
                        cmd.Parameters.AddWithValue("@Phone", Phone);

                        if (Email == null)
                            cmd.Parameters.AddWithValue("@Email", System.DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@Email", Email);
                       
                        cmd.Parameters.AddWithValue("@PersonId", PersonId);
                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception ex)
            {
                clsLogger.WriteLog(ex.Message);
            }
            return rowsAffected != 0;
        }

        public static bool DeletePerson(int PersonId)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
                {
                    connection.Open();
                    string Query = "delete from People where PersonId=@PersonId";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonId", PersonId);
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

