using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigitsAlgorithm
{
    // Program to sum the digits in c#
    // Example: 234 - Sum of the digits = 9
    class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0, remainder;

            // Prompt the user for input number
            Console.WriteLine("Enter a number: ");

            // convert string to integer
            num = int.Parse(Console.ReadLine());

            while(num > 0)
            {
                remainder = num % 10;
                sum = sum + remainder;
                num = num / 10;
            }
            Console.Write("Sum is: " + sum);
            Console.ReadLine();
        }
    }
}
