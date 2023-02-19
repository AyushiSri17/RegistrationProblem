using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegistrationProblem
{
    public class UserValidation
    {
        public static void ValidateFirstName()
        {
            Console.WriteLine("First Name: ");
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            string input = Console.ReadLine();
            ValidatePattern(input, pattern);
        }
        public static void ValidateLastName() 
        {
            Console.WriteLine("Last Name: ");
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            string input = Console.ReadLine();
            ValidatePattern(input, pattern);
        }
        public static void ValidateEmail()
        {
            Console.WriteLine("Email: ");
            string pattern = "^[a-z]{3,}[.a-z]*@[a-z]{2,}.[a-z]{2,}[.a-z]*$";//abc.xyz@bl.co.in
            //string pattern = "^[a-z]{3,}[.a-z]*?@[a-z]{2,}?.[a-z]{2,}[.a-z]*$";
            //string pattern = "^[a-z]{3,}[.a-z]*[@][a-z]{2,}[.][a-z]{2,}[.a-z]*$";
            string input = Console.ReadLine();
            ValidatePattern(input, pattern);
        }
        public static void ValidateMobileNumber()
        {
            Console.WriteLine("Mobile Number: ");
            string pattern = @"^[+]?[0-9]{2}\s[0-9]{10}$";
            //string pattern = "^[+]?[0-9]{2}\\s[0-9]{10}$";
            string input = Console.ReadLine();
            ValidatePattern(input, pattern);
        }
        public static void ValidatePasswordRule1()
        {
            Console.WriteLine("Password: ");
            string pattern = "^[a-zA-Z0-9]{8,}$";
            string input = Console.ReadLine();
            ValidatePattern(input, pattern);
        }
        public static void ValidatePasswordRule2()
        {
            Console.WriteLine("Password: ");
            string pattern = "^(?=.*[A-Z]).{8,}$";//* for all . for atleast ?= must match the atleast condition
            string input = Console.ReadLine();
            ValidatePattern(input, pattern);
        }
        public static void ValidatePattern(string input, string pattern)
        {
            if (Regex.IsMatch(input, pattern))
                Console.WriteLine("{0} is valid ", input);
            else
                Console.WriteLine("{0} is invalid ", input);
        }
    }
}
