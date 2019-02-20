using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_LetsReview
{
    // Given a string, S, of length N that is indexed from 0 to N, print its even-indexed and odd-indexed 
    // characters as 2 space-separated strings on a single line.

    // Note: 0 is considered to be an even index.
    // Sample Input: Hacker
    // Sample Output: Hce  akr

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string S = Console.ReadLine();

            char[] strArray = S.ToArray();

            for(int i = 0; i < strArray.Length; i++)
            {
                if(i == 0 || i % 2 == 0)
                {
                    Console.Write(strArray[i]);
                }
            }
            Console.Write("  ");
            for(int j = 0; j < strArray.Length; j++)
            {
                if(j % 2 == 1)
                {
                    Console.Write(strArray[j]);
                }
            }
            Console.WriteLine();
        }
    }
}
