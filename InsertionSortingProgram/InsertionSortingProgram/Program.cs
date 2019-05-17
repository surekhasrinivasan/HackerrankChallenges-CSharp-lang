using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSortingProgram
{
    /* The Insertion sort algorithm views the data in two halves.
     * 
     * The left half of sorted elements and the right half of elements to be sorted.
     * 
     * In each iteration, one element from the right half is taken and added to the left half so that the left half is still sorted.
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 83, 12, 3, 34, 60 };
            int i;
            Console.WriteLine("The array before sorting: ");
            for(i = 0; i < arr.Length; i++)
            { 
                Console.Write(arr[i] + " ");
            }
            

        }

        static void InsertSort(int[] inputArr, int n)
        {
            int i, j;
            for(i = 1; i < n; i++)
            {
                int item = inputArr[i];
                int ins = 0; 
                for(j = i-1, j >= 0 && ins != 1; )
                {
                    if (item < inputArr[j])
                    {
                        inputArr[j + 1] = inputArr[j];
                        j--;
                        inputArr[j + 1] = item;

                    }
                    else
                        ins = 1;
                }

            }
        }
    }
}
