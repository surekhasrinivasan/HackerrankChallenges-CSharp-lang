using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_2DArrays
{
    /*
     * Given a 6 x 6 2D Array, A:
        1 1 1 0 0 0
        0 1 0 0 0 0
        1 1 1 0 0 0
        0 0 2 4 4 0
        0 0 0 2 0 0
        0 0 1 2 4 0
      
    * Calculate the hourglass sum for every hourglass in A, then print the maximum hourglass sum.
    * 
    * We define an hourglass in A to be a subset of values with indices falling in this pattern in A's graphical representation:
      
        a b c
          d
        e f g
     * */
    class Program
    {
        static void Main(string[] args)
        {
            //int[][] arr = new int[6][];

            //// Setting maxSum to -63 because that is lowest sum of hourglass (-9 x 7 = -63)
            //int maxSum = -63;

            //for (int i = 0; i < 6; i++)
            //{
            //    arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            //}
            //for (int k = 0; k < 4; k++)
            //{
            //    for (int l = 0; l < 4; l++)
            //    {
            //        int sumTemp = arr[k][l] + arr[k][l + 1] + arr[k][l + 2] + arr[k + 1][l + 1] +
            //        arr[k + 2][l] + arr[k + 2][l + 1] + arr[k + 2][l + 2];
            //        if (sumTemp > maxSum)
            //        {
            //            maxSum = sumTemp;
            //        }
            //    }
            //}
            //Console.WriteLine(maxSum);


            // Prints 6 x 6 2D Array
            int[,] arr = new int[6, 6];
            int count = 0;
            int highestSum = 0;

            for(int i = 0; i < 6; i++)
            {
                for(int j =0; j < 6; j++, count++)
                {
                    arr[i, j] = count;
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            // 21 22 23
            //    28
            // 33 34 35

            // highestSum = 196

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int sumTemp = arr[i , j] + arr[i , j + 1] + arr[i , j + 2] + arr[i + 1, j + 1] +
                    arr[i + 2, j] + arr[i + 2, j + 1] + arr[i + 2, j + 2];
                    if (sumTemp > highestSum)
                    {
                        highestSum = sumTemp;
                    }
                }
            }
            Console.WriteLine(highestSum);
        }
    }
}
