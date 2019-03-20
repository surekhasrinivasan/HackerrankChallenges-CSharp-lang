using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzChallenge
{
    // Program prints from 1 to 100 and for multiples of 3, it prints Fizz and 
    // for multiples of five it prints Buzz instead of numbers. For numbers which 
    // are multiples of both 3 and 5, it prints FizzBuzz.
    class Program
    {
        static void Main(string[] args)
        {
            //for(int i = 1; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}

            Console.WriteLine(FizzBuzz.GetFizzBuzz());
        }
    }
}
