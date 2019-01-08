﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPrimeChallenge
{
    class Program
    {
        // Given a number find if it is Prime number or not 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            bool isprime = true;

            for(int i = 2; i <= Math.Sqrt(number); i++)
            {
                if(number % i == 0)
                {
                    isprime = false;
                    break;
                }
            }

            if (isprime)
            {
                Console.WriteLine("Number is PRIME");
            }
            else
            {
                Console.WriteLine("Number is NOT PRIME");
            }
        }
    }
}
