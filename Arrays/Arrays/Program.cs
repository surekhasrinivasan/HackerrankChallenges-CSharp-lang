using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        // Example for Arrays
        static void Main(string[] args)
        {
            // the numbers of elements we want to hold 
            int arraySize = 4;

            // our array declaration
            string[] stringArray = new string[arraySize]; 

            for(int i = 0; i < arraySize; i++)
            {
                // assign value to Index i
                stringArray[i] = "This is stored in index " + i;

                // Print value saved in index i
                Console.WriteLine(stringArray[i]);
            }
        }
    }
}
