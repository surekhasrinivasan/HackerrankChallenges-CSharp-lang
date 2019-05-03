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
            NullDateTimeLogic(value);
            value = DateTime.Now;
            NullDateTimeLogic(value);
            value = DateTime.Now.AddDays(1);
            NullDateTimeLogic(value);

            // you can use the GetValueOrDefault method on nulls
            value = null;
            Console.WriteLine(value.GetValueOrDefault());
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
