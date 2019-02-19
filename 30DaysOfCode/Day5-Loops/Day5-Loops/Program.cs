using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Loops
{
    // Loops

    // Given an integer, n, print its first 10 multiples. Each multiple n x i(where 1 <=i<= 10) should be 
    // printed on a new line in the form: n x i = result.

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= 10; i++)
            {
               Console.WriteLine("{0} x {1} = {2}", n, i, n * i);
            }
        }
    }
}
