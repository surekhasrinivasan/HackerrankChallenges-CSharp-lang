using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedExceptionExample
{
    // C# allows us to create user-defined or custom 
    // exception. It is used to make the meaningful 
    // exception. To do this, we need to inherit Exception class.
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(String message) : base(message)
        {

        }
    }

    class TestUserDefinedException
    {
        static void Main(string[] args)
        {
        }
    }
}
