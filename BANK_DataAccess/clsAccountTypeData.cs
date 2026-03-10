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
    public static class clsAccountTypeData
    {
        public static DataTable GetAllAccountsType()
        {
            DataTable result = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
                {
                    connection.Open();
                    string Query = "select * from AccountsType;";
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

        public static bool Find(int AccountTypeId, ref string AccountTypeName,ref double StartBalance,ref double WithdrawPerDay,ref double DepositPerDay)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
                {
                    connection.Open();
                    string Query = "select * from AccountsType where AccountTypeId=@AccountTypeId ";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@AccountTypeId", AccountTypeId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;
                                AccountTypeName = reader["AccountTypeName"].ToString();
                                StartBalance = Convert.ToDouble(reader["StartBalance"]);
                                WithdrawPerDay = Convert.ToDouble(reader["WithdrawPerDay"]);
                                DepositPerDay = Convert.ToDouble(reader["DepositPerDay"]);
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
