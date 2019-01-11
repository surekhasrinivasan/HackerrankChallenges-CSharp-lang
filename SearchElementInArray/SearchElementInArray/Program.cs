using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchElementInArray
{
    // Linear Search 

    // Given an array, Search if the element is in the array or not 
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 7, 3, 5, 1, 9, 2 };

            Console.WriteLine("Enter the number to search: ");
            int num = int.Parse(Console.ReadLine());

            bool found = false;

            for(int i = 0; i < arr.Length; i++)
            {
                if(num == arr[i])
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                Console.WriteLine("Element found");
            }
            else
            {
                Console.WriteLine("Element not found");
            }
        }
    }
}
