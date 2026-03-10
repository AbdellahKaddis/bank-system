using BANK_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BANK_Bussiness
{
    public class clsCustomer
    {
        public int CustomerId { get; set; }
        public int PersonId { get; set; }
        public clsPerson PersonInfo { get; set; }
        public clsCustomer()
        {
            CustomerId = -1;
            PersonId = -1;
            PersonInfo = null;
        }

        private clsCustomer(int customerId, int personId)
        {
            CustomerId = customerId;
            PersonId = personId;
            PersonInfo = clsPerson.FindPerson(PersonId);
        }

        public static clsCustomer FindCustomer(int PersonId)
        {
            int CustomerId = -1;
            if(clsCustomerData.FindCustomerByPersonId(PersonId,ref CustomerId))
                return new clsCustomer(CustomerId,PersonId);
            else
                return null;

        }

        public static clsCustomer FindCustomerByCustomerId(int CustomerId)
        {
            int PersonId = -1;
            if (clsCustomerData.FindCustomerByCustomerId(CustomerId,ref PersonId))
                return new clsCustomer(CustomerId, PersonId);
            else
                return null;
        }
        public static DataTable GetAllCustomers()
        {
            return clsCustomerData.GetAllCustomers();
        }

        public static bool DeleteCustomer(int CustomerId)
        {
            return clsCustomerData.DeleteCustomer(CustomerId);
        }
        public static bool IsExist(int customerId)
        {
            return clsCustomerData.IsExist(customerId);
        }

        public bool AddCustomer()
        {
            CustomerId=clsCustomerData.AddCustomer(PersonId);
            if (CustomerId != -1)
                return true;
            else
                return false;
        }

    }
}
