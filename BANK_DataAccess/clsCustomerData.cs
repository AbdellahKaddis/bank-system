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
    public static class clsCustomerData
    {
        public static DataTable GetAllCustomers()
        {
            DataTable result = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
                {
                    connection.Open();
                    string Query = "select Customers.CustomerId,Customers.PersonId,People.NationalNumber,People.FirstName+' '+People.LastName as FullName,case \r\nWHEN People.Gender='m' THEN 'Male'\r\nWHEN People.Gender='f' THEN 'Female'\r\nELSE 'UNKNOWN'\r\nEND AS Gender,People.DateOfBirth,People.Phone,Accounts.AccountNumber,AccountsType.AccountTypeName,Accounts.Balance,Accounts.OpenDate,Accounts.Status from Customers join People on People.PersonId=Customers.PersonId join Accounts on Accounts.CustomerId=Customers.CustomerId join AccountsType ON AccountsType.AccountTypeId=Accounts.AccountType order by Customers.CustomerId desc;";
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

        
        public static bool IsExist(int CustomerId)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
                {
                    connection.Open();
                    string Query = "select * from Customers where CustomerId=@CustomerId";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerId", CustomerId);
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
        public static bool FindCustomerByPersonId(int PersonId,ref int CustomerId)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
                {
                    connection.Open();
                    string Query = "select * from Customers where PersonId=@PersonId ";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonId", PersonId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;
                                CustomerId = Convert.ToInt32(reader["CustomerId"]);
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

        public static bool FindCustomerByCustomerId(int CustomerId,ref int PersonId)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
                {
                    connection.Open();
                    string Query = "select * from Customers where CustomerId=@CustomerId ";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerId", CustomerId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;
                                PersonId = Convert.ToInt32(reader["PersonId"]);
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

        public static int AddCustomer(int PersonId)
        {
            int CustomerId = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
                {
                    connection.Open();
                    string Query = "insert into Customers values (@PersonId);select SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        
                        command.Parameters.AddWithValue("@PersonId", PersonId);

                        object Result = command.ExecuteScalar();
                        if (Result != null && int.TryParse(Result.ToString(), out int Id))
                        {
                            CustomerId = Id;
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                clsLogger.WriteLog(ex.Message);
            }
            return CustomerId;
        }

        public static bool DeleteCustomer(int CustomerId)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
                {
                    connection.Open();
                    string Query = "delete from Customers where CustomerId=@CustomerId";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerId", CustomerId);
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
