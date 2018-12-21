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
            int[] arrNum = { 8, 3, 6, 7 };

            foreach(int value in arrNum)
            {
                Console.Write(value);
            }
            Console.WriteLine();

            Array.Reverse(arrNum);

            foreach(int value in arrNum)
            {
                Console.Write(value);
            }
            Console.WriteLine();
        }
    }
}
