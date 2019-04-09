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
            int i, j, k = 1;
            for(i = 1; i <= 10; i++)
            {
                for(j = 1; j < i + 1; j++)
                {
                    Console.Write(k++ + " ");
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
