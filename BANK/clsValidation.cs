using System;
using System.Text.RegularExpressions;


namespace BANK
{
    public static class clsValidation
    {
        public static bool IsEmailFormatValid(string Email)
        {
            string EmailRegularExpression = "[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?";
            Regex regex = new Regex(EmailRegularExpression);
            return regex.IsMatch(Email);    
        }
    }
}
