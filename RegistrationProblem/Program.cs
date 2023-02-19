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
            Console.WriteLine("1. Validate First Name \n2. Validate Last Name \n3. Validate Email \n4. Validate Mobile Number " +
                "\n5. Validate Password Rule1 \n6. Validate Password Rule2 \n7. Validate Password Rule3 " +
                "\n8. Validate Password Rule4");
            int option=Convert.ToInt32(Console.ReadLine()); 
            switch(option)
            {
                case 1:
                    UserValidation.ValidateFirstName();
                    break;
                case 2:
                    UserValidation.ValidateLastName();
                    break;
                case 3:
                    UserValidation.ValidateEmail();
                    break;
                case 4:
                    UserValidation.ValidateMobileNumber();
                    break;
                case 5:
                    UserValidation.ValidatePasswordRule1();
                    break;
                case 6:
                    UserValidation.ValidatePasswordRule2();
                    break;
                case 7:
                    UserValidation.ValidatePasswordRule3();
                    break;
                case 8:
                    UserValidation.ValidatePasswordRule4();
                    break;
                default:
                    Console.WriteLine("Please Choose the correct option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
