using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionsExamples
{
    // Program to show usage of Recursion
    class Program
    {
        // Find Summation of an integer - Addition of all the previous numbers for a given integer 
        // eg: int 5 - Summation(5) is 5 + 4 + 3 + 2 + 1 + 0 = 15
        public static int Summation(int n)
        {
            // Base Case : we are at the end
            if (n <= 0)
            {
                return 0; // additive identity property
            }
            // Recursive Case : Keep going
            else
            {
                // for ex: int n = 3
                // 3 + Summation(2)
                // 3 + 2 + Summation(1)
                // 3 + 2 + 1 + Summation(0)
                // 3 + 2 + 1 + 0 = 6
                return n + Summation(n - 1);
            }

        }

        // Find the Factorial of an integer 
        // eg: int 5 - 5! or Factorial(5) is 5 * 4 * 3 * 2 * 1 = 120
        public static int Factorial(int n)
        {
            // Base Case
            if(n <= 1)
            {
                return 1; // multiplication identity property
            }
            else
            // Recursive Case
            {
                return n * Factorial(n - 1);
            }
        }

        // Find exponentiation
        // eg: int n = 3, p = 5 - Exponentiation(3, 5) is 3^5 = 3 * 3 * 3 * 3 * 3 = 243
        public static int Exponentiation(int n, int p)
        {
            // Base Case
            if(p <= 0)
            {
                return 1; // multiplication identity
            }
            // Recursive Case
            else
            {
                return n * Exponentiation(n, p - 1);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The summation of {0} is {1}", n, Summation(n));
            Console.WriteLine("The Factorial of {0} is {1}", n, Factorial(n));

            Console.WriteLine("Enter an intger which is power to the previous integer: ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Exponentiation of {0} to the power {1} is {2}", n, p, Exponentiation(n, p));
        }
    }
}
