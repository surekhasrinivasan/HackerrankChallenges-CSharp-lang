using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSortingProgram
{
    // Program to Perform a Selection Sort
    class Program
    {
        static void Main(string[] args)
        {
            int array_size = 10;
            int[] array = new int[10] { 100, 50, 20, 40, 10, 60, 80, 70, 90, 30 };
            Console.WriteLine("The array before Selecton sort is :");
            for (int i = 0; i < array_size; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
