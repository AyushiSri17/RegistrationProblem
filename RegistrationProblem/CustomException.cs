using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationProblem
{
    public class CustomException:Exception
    {
        public ExceptionTypes exceptionTypes;
        public enum ExceptionTypes
        {
            EMPTY_INPUT,
            NULL_INPUT,
        }
        public CustomException(string input, ExceptionTypes exceptionTypes) : base(input)
        {
            this.exceptionTypes = exceptionTypes;
        }
    }
}
