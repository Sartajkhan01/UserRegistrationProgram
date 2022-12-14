using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationPrograms
{
    public class EmailSampleValidation
    {
        public static string Email_Regex = "^[a-zA-Z0-9]+([._+-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+.[a-zA-Z]{2,4}([.][a-zA-Z]{2,})?$";
        public bool ValidateEmail(string email)
        {
            if (Regex.IsMatch(email, Email_Regex))
            {
                Console.WriteLine("Email is valid");
                return true;
            }
            else
            {
                Console.WriteLine("Email is invalid");
                return false;
            }
        }
    }
}
