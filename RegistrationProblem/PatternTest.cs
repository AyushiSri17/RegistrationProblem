using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegistrationProblem
{
    public class PatternTest
    {
        public string ValidatePattern(string input, string pattern)
        {
            try
            {
                if (input.Equals(string.Empty))
                    throw new CustomException("Input is empty", CustomException.ExceptionTypes.EMPTY_INPUT);
                else if (Regex.IsMatch(input, pattern))
                    return "Valid";
                else
                    return "Invalid";
            }
            catch (NullReferenceException)
            {
                throw new CustomException("Input is null", CustomException.ExceptionTypes.NULL_INPUT);
            }
        }

        public string Validation_Lambda(string input,string pattern) => Regex.IsMatch(input,pattern) ? "Valid" : "Invalid";
    }
}
