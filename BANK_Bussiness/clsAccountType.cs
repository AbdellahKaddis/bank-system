using BANK_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK_Bussiness
{
    public class clsAccountType
    {

        public int AccountTypeId {  get; set; }
        public string AccountTypeName { get; set; }
        public double StartBalance { get; set; }
        public double WithdrawPerDay { get; set; }
        public double DepositPerDay { get; set; }

        public clsAccountType()
        {
            AccountTypeId = -1;
            AccountTypeName = "";
            StartBalance = -1;
            WithdrawPerDay = -1;
            DepositPerDay=-1;
        }

        private clsAccountType(int accountTpeId,string accountTypeName, double startBalance, double withdrawPerDay, double depositPerDay)
        {
            AccountTypeId = accountTpeId;
            AccountTypeName = accountTypeName;
            StartBalance = startBalance;
            WithdrawPerDay = withdrawPerDay;
            DepositPerDay = depositPerDay;
        }
        public static DataTable GetAllAccountsType()
        {
            return clsAccountTypeData.GetAllAccountsType();
        }

        public static clsAccountType Find(int AccountTypeId)
        {
            string AccountTypeName = "";
            double StartBalance = -1;
            double WithdrawPerDay = -1;
            double DepositPerDay = -1;

            if(clsAccountTypeData.Find(AccountTypeId,ref AccountTypeName,ref StartBalance,ref WithdrawPerDay,ref DepositPerDay))
                return new clsAccountType(AccountTypeId,AccountTypeName,StartBalance,WithdrawPerDay,DepositPerDay);
            else
                return null;
        }
    }
}
