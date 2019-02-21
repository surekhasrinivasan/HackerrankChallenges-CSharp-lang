using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Recursion
{
    // Write a factorial function that takes a positive integer, N as a parameter and prints the result of N! (N factorial).
    class Program
    {
        // Complete the factorial function below.
        static int factorial(int n)
        {
            // Base Case
            if (n <= 1)
            {
                return 1;
            }
            // Recursive Case
            else
            {
                return n * factorial(n - 1);
            }
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int result = factorial(n);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
