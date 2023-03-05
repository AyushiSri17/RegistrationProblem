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
                "\n8. Validate Password Rule4 \n9. Validate All Emails \n10. Validation Using Lambda Expression");
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
                case 9:
                    UserValidation.ValidateAllEmails();
                    break;
                case 10:
                    PatternTest pt= new PatternTest();
                    Console.WriteLine(pt.Validation_Lambda("Ayushi", "^[A-Z]{1}[a-z]{2,}$"));
                    Console.WriteLine(pt.Validation_Lambda("Srivastava", "^[A-Z]{1}[a-z]{2,}$"));
                    Console.WriteLine(pt.Validation_Lambda("abc.xyz@bl.co.in", "^[a-z]{3,}[.a-z]*@[a-z]{2,}.[a-z]{2,}[.a-z]*$"));
                    Console.WriteLine(pt.Validation_Lambda("+91 9999555511", @"^[+]?[0-9]{2}\s[0-9]{10}$"));
                    Console.WriteLine(pt.Validation_Lambda("ahjhjA@5hg", "^(?=.*[A-Z])(?=.*[0-9])(?=.*[@#$?^&]).{8,}$"));
                    break;
                default:
                    Console.WriteLine("Please Choose the correct option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
