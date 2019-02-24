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
            int[][] arr = new int[6][];

            // Setting maxSum to -63 because that is lowest sum of hourglass (-9 x 7 = -63)
            int maxSum = -63;

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }
            for (int k = 0; k < 4; k++)
            {
                for (int l = 0; l < 4; l++)
                {
                    int sumTemp = arr[k][l] + arr[k][l + 1] + arr[k][l + 2] + arr[k + 1][l + 1] +
                    arr[k + 2][l] + arr[k + 2][l + 1] + arr[k + 2][l + 2];
                    if (sumTemp > maxSum)
                    {
                        maxSum = sumTemp;
                    }
                }
            }
            Console.WriteLine(maxSum);
        }
    }
}
