using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingArrays
{
    class Program
    {
        // Given an array, sort it in ascending order or descending order
        static void Main(string[] args)
        {
            // sorting in ascending order
            int[] arr = new int[] { 7, 3, 5, 1, 9, 2 };
            int temp;

            for(int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if(arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Ascending order sorting");
            foreach(int item in arr)
            {
                Console.WriteLine(item);
            }

            // sorting in descending order
            //int[] arr1 = new int[] { 7, 3, 5, 1, 9, 2 };
            //int temp1;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Descending order sorting");
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}