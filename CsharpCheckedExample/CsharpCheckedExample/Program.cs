using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCheckedExample
{
    // Program to demo example for Checked and Unchecked

    // The checked keyword is used to explicitly check overflow and conversion of integral type values at compile time.
    class Program
    {
        static void Main(string[] args)
        {
            // C# Checked Example without using checked
            //int val = int.MaxValue;
            //Console.WriteLine(val + 2); // output : -2147483647

            // C# Checked Example using checked
            //checked
            //{
            //    int val = int.MaxValue;
            //    Console.WriteLine(val + 2); // output: Unhandled Exception: System.OverflowException: Arithmetic operation resulted in an overflow.
            //}

            // The Unchecked keyword ignores the integral type arithmetic exceptions. It does not check 
            // explicitly and produce result that may be truncated or wrong.

            unchecked
            {
                int val = int.MaxValue;
                Console.WriteLine(val + 2); // output: -2147483647
            }
        }
    }
}
