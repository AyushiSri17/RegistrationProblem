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
        public static void ValidatePattern(string input, string pattern)
        {
            if (Regex.IsMatch(input, pattern))
            {
                Console.WriteLine("{0} is valid ", input);
            }
            else
            {
                Console.WriteLine("{0} is invalid ", input);
            }
        }
    }
}
