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
            Add(10, 20);
        }

        public static void Add(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine(sum);
        }
    }
}
