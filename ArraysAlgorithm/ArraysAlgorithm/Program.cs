using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAlgorithm
{
    class Program
    {
        // Given an array, A, of N integers, print A's elements in reverse order as a single line of space-separated numbers.
        static void Main(string[] args)
        {
            // using reverse method.
            //int[] arrNum = { 8, 3, 6, 7 };

            //foreach(int value in arrNum)
            //{
            //    Console.Write(value);
            //}
            //Console.WriteLine();

            //Array.Reverse(arrNum);

            //foreach(int value in arrNum)
            //{
            //    Console.Write(value);
            //}
            //Console.WriteLine();

            // Without using reverse method
            //    int[] arr = new int[20];

            //    int i, j, n, temp;

            //    Console.WriteLine("Enter the number of elements in an array: ");
            //    n = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter the elements of the array: ");
            //    for(i = 0; i < n; i++)
            //    {
            //        arr[i] = int.Parse(Console.ReadLine());
            //    }

            //    j = i - 1;

            //    for(i = 0; i < j; i++)
            //    {
            //        temp = arr[i];
            //        arr[i] = arr[j];
            //        arr[j] = temp;
            //        j--;
            //    }

            //    Console.WriteLine("Elements after reversing the array: ");
            //    for(i = 0; i < n; i++)
            //    {
            //        Console.Write(" " + arr[i]);                
            //    }
            //    Console.ReadLine();
            //}

            Console.WriteLine("Enter number of elements in an array : ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter array elements: ");
            //int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            string[] arrTemp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arrTemp, Int32.Parse);
            int i, j, temp;

            for(i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }

            j = i - 1;

            for (i = 0; i < j; i++)
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                j--;
            }

            Console.WriteLine("Elements after reversing the array: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i]);
                Console.Write(' ');
            }
            Console.ReadLine();
        }
    }
}
