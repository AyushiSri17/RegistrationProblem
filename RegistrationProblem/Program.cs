using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Registration Program");
            Console.WriteLine("Choose the option for validation you want to perform");
            Console.WriteLine("1. Validate First Name \n2. Validate Last Name");
            int option=Convert.ToInt32(Console.ReadLine()); 
            switch(option)
            {
                case 1:
                    UserValidation.ValidateFirstName();
                    break;
                case 2:
                    UserValidation.ValidateLastName();
                    break;
                default:
                    Console.WriteLine("Please Choose the correct option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
