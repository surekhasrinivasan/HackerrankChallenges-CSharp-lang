using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullDateTimeProgram
{
    // Program to assign null value to Datetime
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a nullable DateTime instance and assign to null
            DateTime? value = null;
        }

        static void NullDateTimeLogic(DateTime? value)
        {
            // This method uses the HasValue property. If there is no value, then the output will be zero.
            if (value.HasValue)
            {
                Console.WriteLine(value.Value);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
