using BANK_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK_Bussiness
{
    public class clsAccount
    {
        public int AccountNumber {  get; set; }

        public enum enAccountsType { SavingAccount =1, CheckingAccount =2, MoneyMarketAccount=3 }
        public int AccountType { get; set; }
        public double Balance { get; set; }
        public DateTime OpenDate { get; set; }
        public string Status { get; set; }
        public int CustomerId { get; set; }

        public clsCustomer CustomerInfo { get; }

        public clsAccountType AccountTypeInfo;
        public int CreatedByUserId { get; set; }

        public clsAccount() 
        {
            AccountNumber = -1;
            AccountType = -1;
            Balance = -1;
            OpenDate = new DateTime();
            Status = "";
            CustomerId = -1;
            CustomerInfo = null;
            AccountTypeInfo=null;
            CreatedByUserId = -1;
        }

        private clsAccount(int accountNumber, int accountType, double balance, DateTime openDate, string status, int customerId, int createdByUserId)
        {
            AccountNumber = accountNumber;
            AccountType = accountType;
            AccountTypeInfo = clsAccountType.Find(AccountType);
            Balance = balance;
            OpenDate = openDate;
            Status = status;
            CustomerId = customerId;
            CustomerInfo = clsCustomer.FindCustomerByCustomerId(CustomerId);
            CreatedByUserId = createdByUserId;
        }
        public static clsAccount FindAccount(int AccountNumber)
        {
            int AccountType = -1;
            double Balance = -1;
            DateTime OpenDate = new DateTime();
            string Status = "";
            int CustomerId = -1;
            int CreatedByUserId = -1;

            if (clsAccountData.FindAccount(AccountNumber, ref AccountType, ref Balance, ref OpenDate, ref Status, ref CustomerId, ref CreatedByUserId))
                return new clsAccount(AccountNumber, AccountType, Balance, OpenDate, Status, CustomerId, CreatedByUserId);
            else
                return null;
        }

        public static DataTable FilterByOpenDate(DateTime OpenDate)
        {
            return clsAccountData.FilterByOpenDate(OpenDate);
        }
        public static DataTable FilterByAccountType(string AccountType)
        {
            return clsAccountData.FilterByAccountType(AccountType);
        }
        public bool AddAccount()
        {
           AccountNumber=clsAccountData.AddAccount(AccountType, Balance,OpenDate,Status,CustomerId,CreatedByUserId);
            if (AccountNumber != -1)
                return true;
            else 
                return false;
        }

        public bool ChangeAccountStatus(byte Status)
        {
            return clsAccountData.ChangeAccountStatus(AccountNumber,Status);
        }

        public static bool ChangeAccountStatus(int AccountNumber,byte Status)
        {
            return clsAccountData.ChangeAccountStatus(AccountNumber, Status);
        }

        public static bool IsCustomerHaveAnotherAccount(int CustomerId)
        {
            return clsAccountData.IsCustomerHaveAnotherAccount(CustomerId);
        }
        public static bool IsThisPersonHaveAnAccountNumberOfThisType(int AccountType, int PersonId)
        {
            return clsAccountData.IsAPersonHaveAnotherAccountOfTheSameType(AccountType, PersonId);
        }
        public static bool IsExist(int AccountNumber)
        {
            return clsAccountData.IsExist(AccountNumber);
        }

        public static DataTable GetAllAccounts()
        {
            return clsAccountData.GetAllAccounts();
        }

        public static bool DeleteAccount(int AccountNumber)
        {
            return clsAccountData.DeleteAccount(AccountNumber);
        }

        public  bool DeleteAccount()
        {
            return clsAccountData.DeleteAccount(AccountNumber);
        }

        public bool Withdraw(double Amount)
        {
            return clsAccountData.Transaction(AccountNumber, Balance - Amount);
        }

        public bool Deposit(double Amount)
        {
            return clsAccountData.Transaction(AccountNumber, Balance + Amount);
        }
    }
}
