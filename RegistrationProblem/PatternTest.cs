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
            if (Regex.IsMatch(input, pattern))
                return "Valid";
            else
                return "Invalid";
        }
    }
}
