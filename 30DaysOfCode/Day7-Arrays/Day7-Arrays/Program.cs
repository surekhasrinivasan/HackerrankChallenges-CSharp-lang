using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Arrays
{
    // Given an array, A, of N integers, print A's elements in reverse order as a single line of space-separated numbers.

    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 3, 2, 7, 8 };

            //Array.Reverse(numbers);
            //foreach(var num in numbers)
            //{
            //    Console.Write(num);
            //    Console.Write(' ');
            //}
            //Console.WriteLine();

            int[] arr = { 3, 4, 5, 6 };

            // Without using Reverse method
            int i, j, temp;

            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i];
            }
            j = i - 1;

            for (i = 0; i < j; i++)
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                j--;
            }

            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                Console.Write(' ');
            }
            Console.WriteLine();
        }
    }
}
