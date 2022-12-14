﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationPrograms
{
    public class DataValidation
    {
        public Regex First_Name_Regex = new Regex(@"^[A-Z]{1}[A-Za-z]{2,}?$");
        public Regex Last_Name_Regex = new Regex(@"^[A-Z]{1}[A-Za-z]{2,}?$");
        public Regex Email_Regex = new Regex("^[A-Za-z]{3,}([.][A-Za-z]{3,})?[@][A-Za-z]{2,}[.][A-Za-z]{2,}([.][A-Za-z]{2})?$");
        public void ValidateFirstName()
        {
            Console.Write("Enter First Name : ");
            string firstName = Console.ReadLine();

            if (First_Name_Regex.IsMatch(firstName))
            {
                Console.WriteLine("The First Name Is Valid ");
            }
            else
            {
                Console.WriteLine("The First Name Is Not Valid");
            }
        }
        public void ValidateLastName()
        {
            Console.Write("Enter Last Name : ");
            string lastName = Console.ReadLine();

            if (Last_Name_Regex.IsMatch(lastName))
            {
                Console.WriteLine("The Last Name Is Valid ");
            }
            else
            {
                Console.WriteLine("The Last Name Is Not Valid");
            }
        }
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
