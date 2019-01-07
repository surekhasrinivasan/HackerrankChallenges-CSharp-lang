using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDuplicatesChallenge
{
    // Given an array of integers, Find the duplicates in the array and the number of its occurrences 
    class Program
    {
        static void Main()
        {
            int[] arr = { 2, 1, 3, 5, 3, 2 };

            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {

                for (int j = i; j < arr.Length - 1; j++)
                {
                    if (arr[i] == arr[j + 1])
                    {
                        count++;
                        Console.WriteLine("The duplicate integers are: " + arr[i]);
                    }
                }
            }
        }
    }
}
