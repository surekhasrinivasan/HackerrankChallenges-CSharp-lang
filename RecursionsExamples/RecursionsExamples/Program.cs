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
        public static int Summation(int n)
        {
            // Base Case : we are at the end
            if (n <= 0)
            {
                return 0;
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

        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The summation of {0} is {1}", n, Summation(n));
        }
    }
}
