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
            int tmp, min_key;

            for (int j = 0; j < array_size - 1; j++)
            {
                min_key = j;

                for (int k = j + 1; k < array_size; k++)
                {
                    if (array[k] < array[min_key])
                    {
                        min_key = k;
                    }
                }

                tmp = array[min_key];
                array[min_key] = array[j];
                array[j] = tmp;
            }

            Console.WriteLine("The array after Selecton sort is :");
            for (int i = 0; i < array_size; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
