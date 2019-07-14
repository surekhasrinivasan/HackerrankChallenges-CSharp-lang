using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNumberTriangle
{
    // Program to print Number Triangle
    class Program
    {
        static void Main(string[] args)
        {
            int num, i, j, k, l;

            // Prompt the user for the input range
            Console.WriteLine("Enter the Range: ");

            // convert string to integer
            num = int.Parse(Console.ReadLine());

            for (i = 1; i <= num; i++)
            {
                for (j = 1; j <= num - i; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write(k);
                }

            }
        }
    }
}
