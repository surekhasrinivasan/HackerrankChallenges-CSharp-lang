using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    // Program to print a series of Fibonacci numbers 

    // Fibonacci series is a sequence of numbers in below order:
    // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34… The next number is found by adding up the two numbers before it.
    class Program
    {
        // Recursive Approach : In this approach, We need to pass the length of 
        // the Fibonacci Series to the recursive method and then it iterates 
        // continuously until it reaches the length.

        static int FibonacciSeries(int n)
        {
            if (n == 0) return 0; // To return the first Fibonacci number
            if (n == 1) return 1; // To return the second Fibonacci number

            return FibonacciSeries(n - 1) + FibonacciSeries(n - 2);
        }

        static void Main()
        {
            Console.WriteLine("Enter the length of the Fibonacci Series: ");
            int len = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < len; i++)
            {
                Console.Write("{0} \t", FibonacciSeries(i));
            }
            Console.WriteLine();
        }
        //static int FibonacciSeries(int n)
        //{
        //    int firstnumber = 0,
        //        secondnumber = 1,
        //        result = 0;

        //    // To return the first Fibonacci number
        //    if (n == 0)
        //        return 0;

        //    // To return the second Fibonacci number
        //    if (n == 1)
        //        return 1;

        //    for(int i = 2; i <= n; i++)
        //    {
        //        result = firstnumber + secondnumber;
        //        firstnumber = secondnumber;
        //        secondnumber = result;
        //    }
        //    return result;
        //}

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter the length of the Fibonacci Series: ");
        //    int len = Convert.ToInt32(Console.ReadLine());

        //    for(int i = 0; i < len; i++)
        //    {
        //        Console.Write("{0} \t", FibonacciSeries(i));
        //    }
        //    Console.WriteLine();
        //}
    }
}
