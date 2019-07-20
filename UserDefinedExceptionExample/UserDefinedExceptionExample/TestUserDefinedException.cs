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

    public class TestUserDefinedException
    {
        static void validate(int age)
        {
            if(age < 18)
            {
                throw new InvalidAgeException("Sorry, Age must be greater than 18")
            }
        }
        
    }

    public static void Main(string[] args)
    {
    }
}
