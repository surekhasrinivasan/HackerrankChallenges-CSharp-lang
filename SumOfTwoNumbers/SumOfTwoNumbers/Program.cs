using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwoNumbers
{
    // Program to Add sum of two numbers using Add method
    class Program
    {
        static void Main(string[] args)
        {
            int result = Add(20, 35);
            Console.WriteLine(result);
        }

        public static int Add(int num1, int num2)
        {
            int sum = num1 + num2;
            //Console.WriteLine(sum);
            return sum;
        }
    }
}
