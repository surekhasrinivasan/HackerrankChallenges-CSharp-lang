using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintFloydTriangleAndPascalTriangle
{
    // Program to print Floyd's Triangle and Pascal's Triangle 
    class Program
    {
        static void Main(string[] args)
        {
            // Floyd's Triangle 
            Console.WriteLine("Floyd's Triangle Program: \n");
            Console.WriteLine("Enter the number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            int i, j, k = 1;
            for(i = 1; i <= rows; i++)
            {
                for(j = 1; j < i + 1; j++)
                {
                    Console.Write(k++ + " ");
                }
                Console.WriteLine("\n");
            }
            //Console.ReadLine();

            Console.WriteLine("Pascal's Triangle Program: \n");
            Console.WriteLine("Enter the number of rows: ");
            int numberOfRows = Convert.ToInt32(Console.ReadLine());

            for(int a = 0; a < numberOfRows; a++)
            {
                int c = 1;
                for(int b = 0; b < numberOfRows - a; b++)
                {
                    Console.Write("   ");
                }
                for(int d = 0; d <= a; d++)
                {
                    Console.Write("    {0:D}  ", c);
                    c = c * (a - d) / (d + 1);
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
