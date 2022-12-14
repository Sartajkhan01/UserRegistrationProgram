using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationPrograms
{
    public class PasswordRules
    {
        public Regex Password_Regex = new Regex("^[A-Za-z0-9]{8,16}$");
        public void ValidatePassword()
        {
            Console.Write("Enter the password : ");
            string password = Console.ReadLine();

            if (Password_Regex.IsMatch(password))
            {
                Console.WriteLine("The password is valid ");
            }
            else
            {
                Console.WriteLine("Invalid passord");
            }
        }

    }
}
