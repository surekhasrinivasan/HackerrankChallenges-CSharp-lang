using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnRemainder
{
    // Program to accept 2 integers and get remainder back

    // Need to handle System.DivideByZeroException
    // Need to handle case where the dividend(x) is less than the divisor (y)
    class Program
    {
        public static int GetRemainder(int x, int y)
        {
            if(y == 0)
            {
                throw new Exception("Cannot divide by Zero");
            }
            if(x < y)
            {
                throw new Exception("Number being divided(dividend) cannot be less than the divisor");
            }
            else
            {
                return (x % y);
            }
        }

        static void Main(string[] args)
        {
            int result = GetRemainder(15, 4);
            Console.WriteLine(result);            
        }
    }
}
