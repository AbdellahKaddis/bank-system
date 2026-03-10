using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using BANK_DataAccess;


namespace BANK_Bussiness
{
    public class clsPerson
    {
        public int PersonId { get; set; }
        public string NationalNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName { get { return FirstName + " " + LastName; } }

        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public enum enMode { Add,Update}

        public enMode Mode;
        public clsPerson()
        {
            PersonId = -1;
            NationalNumber = "";
            FirstName = "";
            LastName = "";
            Gender = "";
            DateOfBirth = new DateTime();
            Address = "";
            Phone = "";
            Email = "";
            Mode = enMode.Add;
        }

        private clsPerson(int personId,string nationalNumber, string firstName, string lastName, string gender, DateTime dateOfBirth, string address, string phone, string email)
        {
            PersonId = personId;
            NationalNumber = nationalNumber;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            Address = address;
            Phone = phone;
            Email = email;
            Mode = enMode.Update;
        }

        static public DataTable GetAllPeople()
        {
            return clsPersonData.GetAllPeople();
        }

        static public clsPerson FindPerson(string NationalNumber)
        {
            int PersonId = -1;
            string FirstName = "";
            string LastName = "";
            string Gender = "";
            DateTime DateOfBirth = new DateTime(); 
            string Address = ""; 
            string Phone = "";
            string Email = "";

            if (clsPersonData.FindPerson(ref PersonId,NationalNumber, ref FirstName, ref LastName, ref Gender, ref DateOfBirth, ref Address, ref Phone, ref Email))
                return new clsPerson(PersonId,NationalNumber, FirstName, LastName, Gender, DateOfBirth, Address, Phone, Email);
            else
                return null;

        }
        static public clsPerson FindPerson(int PersonId)
        {
            string NationalNumber = "";
            string FirstName = "";
            string LastName = "";
            string Gender = "";
            DateTime DateOfBirth = new DateTime();
            string Address = "";
            string Phone = "";
            string Email = "";

            if (clsPersonData.FindPerson(PersonId,ref NationalNumber, ref FirstName, ref LastName, ref Gender, ref DateOfBirth, ref Address, ref Phone, ref Email))
                return new clsPerson(PersonId, NationalNumber, FirstName, LastName, Gender, DateOfBirth, Address, Phone, Email);
            else
                return null;

        }

        static public bool IsExist(string NationalNumber)
        {
            return clsPersonData.IsExist(NationalNumber);
        }
        static public bool IsExist(int PersonId)
        {
            return clsPersonData.IsExist(PersonId);
        }

        private bool AddPerson()
        {
            PersonId = clsPersonData.AddPerson(NationalNumber,FirstName, LastName, Gender, DateOfBirth, Address, Phone, Email);
            if (PersonId != -1)
                return true;
            else
                return false;
          
        }

        private bool UpdatePerson()
        {
            return clsPersonData.Update(PersonId, NationalNumber, FirstName, LastName, Gender, DateOfBirth, Address, Phone, Email);
        }

        public bool DeletePerson()
        {
            return clsPersonData.DeletePerson(PersonId);
        }
        public static bool DeletePerson(int PersonId)
        {
            return clsPersonData.DeletePerson(PersonId);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    if(AddPerson())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return UpdatePerson();
                default:
                    return false;
            }
        }

    }
}
