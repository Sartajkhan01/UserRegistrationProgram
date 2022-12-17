using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationPrograms
{
    
        public Regex Email_Regex = new Regex("^[A-Za-z]{3,}([.][A-Za-z]{3,})?[@][A-Za-z]{2,}[.][A-Za-z]{2,}([.][A-Za-z]{2})?$");
                                                    //("abc.xyz@bl.co.in")
        
        
        public void ValidateEmail(string email)
        {
            if (Email_Regex.IsMatch(email))
            {
                Console.WriteLine("Email Is Valid ");
            }
            else
            {
                Console.WriteLine("Email Is Not Valid ");
            }
        }
    }
}
