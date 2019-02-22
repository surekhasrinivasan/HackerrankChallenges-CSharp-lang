using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_BinaryNumbers
{
    // Given a base-10 integer, n, convert it to binary (base-2). 
    // Then find and print the base-10 integer denoting the maximum number of consecutive 1's in n's binary representation.

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a base-10 integer: ");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int maxConsecutive = 0;

            while(n > 0)
            {
                if (n % 2 == 1)
                {
                    count++;
                    if (count > maxConsecutive)
                    {
                        maxConsecutive = count;
                    }
                }
                else
                    count = 0;
                n = n / 2;
            }
            Console.WriteLine(maxConsecutive);                 
        }
    }
}
