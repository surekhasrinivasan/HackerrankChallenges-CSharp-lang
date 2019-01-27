using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsDivisibleByTwo
{
    // Program that checks for a number is divisible by 2 or not
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num % 2 == 0)
            {
                Console.WriteLine("Number entered is divisible by 2");
            }
            else
            {
                Console.WriteLine("Number entered is not divisible by 2");
            }
            Console.ReadLine();
        }
    }
}
