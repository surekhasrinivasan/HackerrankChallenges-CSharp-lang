using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2DArrays
{
    // Program to demo 2D Arrays
    class Program
    {
        static void Main(string[] args)
        {
            int rowSize = 2;
            int colSize = 4;
            int count = 0;

            int[ , ] myArray = new int[rowSize, colSize];
            
            for(int i = 0; i < rowSize; i++)
            {
                for(int j = 0; j < colSize; j++, count++)
                {
                    myArray[i , j] = count;
                    Console.Write(myArray[i , j] + " ");
                }
                Console.WriteLine();
            }            
        }
    }
}