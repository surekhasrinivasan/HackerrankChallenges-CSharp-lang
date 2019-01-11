using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesOfArrays
{
    // Different types of Arrays 
    class Program
    {
        static void Main(string[] args)
        {
            //// Multidimension Array - Two dimension Array
            //int[,] arr = new int[3, 4] { { 1, 2, 3, 4 }, { 10, 20, 30, 40 }, { 11, 22, 33, 44 } };

            //for(int i = 0; i < 3; i++)
            //{
            //    for(int j = 0; j < 4; j++)
            //    {
            //        Console.Write(arr[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            // Jagged array - Array of Arrays

            int[][] arr = new int[3][];

            arr[0] = new int[3] { 1, 2, 3 };
            arr[1] = new int[2] { 10, 20 };
            arr[2] = new int[4] { 11, 22, 33, 44 };

            foreach(int[] ar in arr)
            {
                foreach(int item in ar)
                {
                    Console.Write(item + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
