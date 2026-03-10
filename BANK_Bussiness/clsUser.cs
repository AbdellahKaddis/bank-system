using BANK_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK_Bussiness
{
    public class clsUser
    {
        public enum enPermissions { ManagePeople = 1, MangeUsers = 2, ManageCustomers = 4, ManageAccounts = 8, PerformTransactions = 16, ManageLoan = 32 ,FullAccess=-1}
        public int UserId { get; set; }

        public static bool IsAllowed(int UserPermissions,enPermissions permission)
        {
            if (UserPermissions == -1)
                return true;

            if((UserPermissions & Convert.ToInt32(permission)) == Convert.ToInt32(permission))
                return true;
            else
                return false;
        }
        public string Status { get; set; }

        public int Permissions { get; set; }

        public int PersonId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Role {  get; set; }

        public clsPerson PersonInfo { get; set; }
        public enum enMode { Add,Update}

        public enMode Mode;


        public clsUser()
        {
            UserId = -1;
            Status = "";
            Permissions = -1;
            PersonId = -1;
            UserName = "";
            Password = "";
            PersonInfo = null;
            Role = "";
            Mode = enMode.Add;
        }

        private clsUser(int userId, string status, int permissions, int personId, string userName, string password,string role)
        {
            UserId = userId;
            Status = status;
            Permissions = permissions;
            PersonId = personId;
            UserName = userName;
            Password = password;
            PersonInfo = clsPerson.FindPerson(PersonId);
            Role = role;
            Mode = enMode.Update;
        }

        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }
        //ref int UserId, string Status, ref int Permissions, ref int PersonId, string UserName,  string Password)
        public static clsUser FindUser(int UserId)
        {
            string Status = "";
            int Permissions = -1;
            int PersonId = -1;
            string UserName = "";
            string Password = "";
            string Role = "";
            if (clsUserData.FindUser(UserId, ref Status, ref Permissions, ref PersonId, ref UserName, ref Password,ref Role))
                return new clsUser(UserId, Status, Permissions, PersonId, UserName, Password,Role);
            else
                return null;
        }
        public static clsUser FindUser(string UserName)
        {
            string Status = "";
            int Permissions = -1;
            int PersonId = -1;
            int UserId = -1;
            string Password = "";
            string Role = "";
            if (clsUserData.FindUser(ref UserId, ref Status, ref Permissions, ref PersonId,  UserName, ref Password,ref Role))
                return new clsUser(UserId, Status, Permissions, PersonId, UserName, Password, Role);
            else
                return null;
        }

        public static clsUser FindUser(string UserName,string Password)
        {
            string Status = "";
            int Permissions = -1;
            int PersonId = -1;
            int UserId = -1;
            string Role = "";

            if (clsUserData.FindUser(ref UserId, ref Status, ref Permissions, ref PersonId, UserName, Password,ref Role))
                return new clsUser(UserId, Status, Permissions, PersonId, UserName, Password,Role);
            else
                return null;
        }

        public static bool IsExist(string UserName)
        {
            return clsUserData.IsExist(UserName);
        }
        public static bool IsExist(int UserId)
        {
            return clsUserData.IsExist(UserId);
        }
        public static bool IsUserExistByPersonId(int PersonId)
        {
            return clsUserData.IsUserExistByPersonId(PersonId);
        }
        private bool AddUser()
        {
            UserId = clsUserData.AddUser(Status, Permissions, PersonId, UserName, Password,Role);
            if (UserId != -1)
                return true;
            else
                return false;
        }

        private bool UpdateUser()
        {
            return clsUserData.UpdateUser(UserId, Status, Permissions, PersonId, UserName, Password,Role);
        }

        public static bool DeleteUser(int UserId)
        {
            return clsUserData.DeleteUser(UserId);
        }

        public bool DeleteUser()
        {
            return clsUserData.DeleteUser(UserId);
        }

        public static bool ChangePassword(int UserId, string Password)
        {
            return clsUserData.ChangePassword(UserId, Password);
        }

        public bool ChangePassword(string Password)
        {
            return clsUserData.ChangePassword(UserId, Password);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    if(AddUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return UpdateUser();
                default:
                    return false;
            }
        }


    }
}
