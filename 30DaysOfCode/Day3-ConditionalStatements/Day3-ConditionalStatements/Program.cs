using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_ConditionalStatements
{
    // Conditional Statements

    /* Given an integer,n, perform the following conditional actions:
    If n is odd, print Weird
    If n is even and in the inclusive range of 2 to 5, print Not Weird
    If n is even and in the inclusive range of 6 to 20, print Weird
    If n is even and greater than 20, print Not Weird
    Print whether or not n is weird.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 != 0)
            {
                Console.WriteLine("Weird");
            }
            if (n % 2 == 0 && n >= 2 && n <= 5)
            {
                Console.WriteLine("Not Weird");
            }
            if (n % 2 == 0 && n >= 6 && n <= 20)
            {
                Console.WriteLine("Weird");
            }
            if (n % 2 == 0 && n > 20)
            {
                Console.WriteLine("Not Weird");
            }
        }
    }
}
