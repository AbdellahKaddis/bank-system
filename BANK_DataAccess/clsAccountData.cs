using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK_DataAccess
{
    public static class clsAccountData
    {
        public static int AddAccount(int AccountType,double Balance,DateTime OpenDate,string Status,int CustomerId,int CreatedByUserId)
        {
            int AccountNumber = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
                {
                    connection.Open();
                    string Query = "INSERT INTO Accounts values(@AccountType,@Balance,@OpenDate,@Status,@CustomerId,@CreatedByUserId);select SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {

                        command.Parameters.AddWithValue("@AccountType", AccountType);
                        command.Parameters.AddWithValue("@Balance", Balance);
                        command.Parameters.AddWithValue("@OpenDate", OpenDate);
                        command.Parameters.AddWithValue("@Status", Status == "Active"?1:0);
                        command.Parameters.AddWithValue("@CustomerId", CustomerId);
                        command.Parameters.AddWithValue("@CreatedByUserId", CreatedByUserId);

                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedNumber))
                        {
                            AccountNumber = insertedNumber;
                        }

                    }
                }
            }
            catch(Exception e)
            {
                clsLogger.WriteLog(e.Message);
            }
            return AccountNumber;
        }

        public static bool ChangeAccountStatus(int AccountNumber,Byte Status)
        {

            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
                {
                    connection.Open();
                    string Query = "update Accounts set Status=@Status where AccountNumber=@AccountNumber";
                    using (SqlCommand cmd = new SqlCommand(Query, connection))
                    {
                        cmd.Parameters.AddWithValue("@AccountNumber", AccountNumber);

                        cmd.Parameters.AddWithValue("@Status", Status);
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


        public static DataTable GetAllAccounts()
        {
            DataTable result = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
                {
                    connection.Open();
                    string Query = "select Accounts.AccountNumber,AccountsType.AccountTypeName,Accounts.Balance,Accounts.OpenDate,Accounts.Status,People.FirstName+' '+People.LastName as FullName,Accounts.CreatedByUserId from Accounts join Customers on Customers.CustomerId=Accounts.CustomerId JOIN People on People.PersonId=Customers.PersonId JOIN AccountsType on AccountsType.AccountTypeId=Accounts.AccountType order by Accounts.AccountNumber desc;";
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

        public static DataTable FilterByAccountType(string AccountType)
        {
            DataTable result = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
                {
                    connection.Open();
                    string Query = "select Customers.CustomerId,Customers.PersonId,People.NationalNumber,People.FirstName+' '+People.LastName as FullName,case \r\nWHEN People.Gender='m' THEN 'Male'\r\nWHEN People.Gender='f' THEN 'Female'\r\nELSE 'UNKNOWN'\r\nEND AS Gender,People.DateOfBirth,People.Phone,Accounts.AccountNumber,AccountsType.AccountTypeName,Accounts.Balance,Accounts.OpenDate,Accounts.Status from Customers join People on People.PersonId=Customers.PersonId join Accounts on Accounts.CustomerId=Customers.CustomerId join AccountsType ON AccountsType.AccountTypeId=Accounts.AccountType where (AccountsType.AccountTypeName like @AccountType)";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@AccountType", AccountType + "%");
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

        public static DataTable FilterByOpenDate(DateTime OpenDate)
        {
            DataTable result = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
                {
                    connection.Open();
                    string Query = $"select Customers.CustomerId,Customers.PersonId,People.NationalNumber,People.FirstName+' '+People.LastName as FullName,case \r\nWHEN People.Gender='m' THEN 'Male'\r\nWHEN People.Gender='f' THEN 'Female'\r\nELSE 'UNKNOWN'\r\nEND AS Gender,People.DateOfBirth,People.Phone,Accounts.AccountNumber,AccountsType.AccountTypeName,Accounts.Balance,Accounts.OpenDate,Accounts.Status from Customers join People on People.PersonId=Customers.PersonId join Accounts on Accounts.CustomerId=Customers.CustomerId join AccountsType ON AccountsType.AccountTypeId=Accounts.AccountType where (DATEPART(YY,Accounts.OpenDate)={OpenDate.Year} AND   DATEPART(MM,Accounts.OpenDate)={OpenDate.Month}AND DATEPART(DD,Accounts.OpenDate)={OpenDate.Day});";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@OpenDate", OpenDate + "%");
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

        public static bool DeleteAccount(int AccountNumber)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
                {
                    connection.Open();
                    string Query = "delete from Accounts where AccountNumber=@AccountNumber";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
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

        public static bool Transaction(int AccountNumber,double Amount)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
                {
                    connection.Open();
                    string Query = "update  Accounts set Balance=@Amount  where AccountNumber=@AccountNumber";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@Amount", Amount);
                        command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
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

        public static bool IsExist(int AccountNumber)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
                {
                    connection.Open();
                    string Query = "select * from Accounts where AccountNumber=@AccountNumber";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
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

        public static bool IsAPersonHaveAnotherAccountOfTheSameType(int AccountType,int PersonId)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
                {
                    connection.Open();
                    string Query = "select Found=1 from Accounts JOIN Customers on Customers.CustomerId=Accounts.CustomerId where Customers.PersonId=@PersonId and Accounts.AccountType=@AccountType;";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@AccountType", AccountType);
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

        public static bool IsCustomerHaveAnotherAccount(int CustomerId)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
                {
                    connection.Open();
                    string Query = "select Found=1 from Accounts where CustomerId=@CustomerId;";
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
        public static bool FindAccount(int AccountNumber, ref int AccountType, ref double Balance, ref DateTime OpenDate, ref string Status, ref int CustomerId, ref int CreatedByUserId)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
                {
                    connection.Open();
                    string Query = "select * from Accounts where AccountNumber=@AccountNumber";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;
                                Status = Convert.ToByte(reader["Status"]) == 0 ? "Closed" : "Active";
                                Balance = Convert.ToDouble(reader["Balance"]);
                                OpenDate = Convert.ToDateTime(reader["OpenDate"]);
                                CustomerId = Convert.ToInt32(reader["CustomerId"]);
                                AccountType = Convert.ToInt32(reader["AccountType"]);
                                CreatedByUserId = Convert.ToInt32(reader["CreatedByUserId"]);
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

    }
}
