using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOfNumber
{
    // Program to calculate the power of a number using recursion
    class Program
    {
        static void Main(string[] args)
        {
            double result = PowerOfANumber(5, 4);
            Console.WriteLine(result);
        }

        public static double PowerOfANumber(double baseNumber, int exponent)
        {
            if (exponent < 0)
            {
                Console.Error.WriteLine("Usage of this function is limited to positive exponents only");
                throw new Exception();
            }
            else if (exponent == 0)
            {
                return 1;
            }
            else if (exponent == 1)
            {
                return baseNumber;
            }
            else
            {
                return baseNumber * PowerOfANumber(baseNumber, exponent - 1);
            }
        }
    }
}
