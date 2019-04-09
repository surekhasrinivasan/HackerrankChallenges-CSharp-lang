using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateGCDAndLCM
{
    // Program to calculate Greatest Common Divisor and Least Common Multiple of 2 given number 
    class Program
    {
        static int GetGCD(int number1, int number2)
        {
            while(number1 != number2)
            {
                if(number1 > number2)
                {
                    number1 = number1 - number2;
                }
                if(number2 > number1)
                {
                    number2 = number2 - number1;
                }
            }
            return number1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int gcd = GetGCD(num1, num2);
            Console.WriteLine("The greatest common divisor is: {0}", gcd);
        }
    }
}
