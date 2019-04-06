using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day25_RunningTimeAndComplexity
{
    /* Task 
     * 
     * A prime is a natural number greater than 1 that has no positive divisors other than 1 and itself. 
     * Given a number, n, determine and print whether it's Prime or Not prime.
     * 
     * Input Format
     * The first line contains an integer, T, the number of test cases. 
     * Each of the T subsequent lines contains an integer, n, to be tested for primality.
     * 
     * Sample Input
     * 
     * 3
     * 12
     * 5
     * 7
     * 
     * Sample Output
     * 
     * Not prime
     * Prime
     * Prime
     */
    class Program
    {
        public static void isPrime(int num)
        {
            bool isPrime = true;
            if(num == 1)
            {
                isPrime = false;
            }
            // If a number is divisible by another number less or equal to the square root of the first number. it is NOT prime.
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if(num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not prime");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of testcases: ");
            int T = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the integers to be tested for primality: ");
            while (T-- > 0)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                isPrime(input);
            }
        }
    }
}
