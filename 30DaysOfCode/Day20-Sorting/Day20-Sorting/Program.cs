using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20_Sorting
{
    /* Task 
     * 
     * Given an array, a, of size n distinct elements, sort the array in ascending order using the Bubble Sort algorithm. Once sorted, print the following  lines:

        1. Array is sorted in numSwaps swaps.
        where numSwaps is the number of swaps that took place
        
        2. First Element: firstElement 
        where firstElement is the first element in the sorted array.
        
        3. Last Element: lastElement 
        where lastElement is the last element in the sorted array.
        
        Hint: To complete this challenge, you will need to add a variable that keeps a running tally of all swaps that occur during execution.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements in an array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the space-separated elements of the array: ");
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            int numSwaps = 0;

            // Write Your Code Here
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if(a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                        numSwaps++;
                    }                    
                }
                if(numSwaps == 0)
                {
                    break;
                }                    
            }            
            Console.WriteLine("Array is sorted in {0} swaps.", numSwaps);
            Console.WriteLine("First Element: {0}", a[0]);
            Console.WriteLine("Last Element: {0}", a[n - 1]);
        }
    }
}