using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAlgorithm
{
    class Program
    {
        /* Given a string, S, of length N that is indexed from 0 to N-1, print its even-indexed 
         * and odd-indexed characters as 2 space-separated strings on a single line.
        *  Note: 0 is considered to be an even index.
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string myStr = Console.ReadLine();

            char[] myCharArray = myStr.ToCharArray();

            for (int i = 0; i < myStr.Length; i++)
            {
                if ((i == 0) || (i % 2 == 0))
                {
                    Console.Write(myCharArray[i]);

                }
            }
            Console.Write(" ");
            for (int j = 0; j < myStr.Length; j++)
            {
                if (j % 2 == 1)
                {
                    Console.Write(myCharArray[j]);
                }
            }
            Console.WriteLine();
        }
    }
}
