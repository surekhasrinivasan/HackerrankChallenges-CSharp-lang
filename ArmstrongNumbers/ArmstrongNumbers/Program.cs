using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumbers
{
    // Program to Check Whether the Entered Number is an Armstrong Number or Not

    // An Armstrong number of three digits is an integer such that the sum of the cubes of its digits is equal to the number itself.
    class Program
    {
        static void Main(string[] args)
        {
            int number, remainder, sum = 0; 
            Console.WriteLine("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = number; i > 0; i = i / 10)
            {
                remainder = i % 10;
                sum = sum + remainder * remainder * remainder;
            }

            if(sum == number)
            {
                Console.WriteLine("Entered number is armstrong number");
            }
            else
            {
                Console.WriteLine("Entered number is not armstrong number");
            }
            Console.ReadLine();
        }
    }
}

/// Another method to solve above challenge
/// 
bool IsArmstrong(int number)
{
    var digitsCount = (int)Math.Floor(Math.Log10(number)) + 1;
    var total = 0;
    var tmp = number;
    for (var i = 0; i < digitsCount; i++)
    {
        var digit = tmp % 10;
        total += (int)Math.Pow(digit, digitsCount);
        tmp = tmp / 10;
    }

    return total == number;
}
