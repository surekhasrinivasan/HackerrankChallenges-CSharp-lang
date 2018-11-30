using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare second integer, double, and String variables.

            int x = 5;
            double a = 2.5;
            string s1 = "My name is: ";

            // Read and save an integer, double, and String to your variables.

            Console.WriteLine("Enter an integer: ");
            int y = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter a double: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your name: ");
            string s2 = Console.ReadLine();


            // Print the sum of both integer variables on a new line.

            Console.WriteLine("Sum of two integers: x = {0}, y = {1}, Result = {2}", x,y, (x + y));


            // Print the sum of the double variables on a new line.

            Console.WriteLine("Sum of two doubles: a = {0}, b = {1}, Result = {2} ", a, b, (a + b));

            // Concatenate and print the String variables on a new line
            // The 's1' variable above should be printed first.

            Console.WriteLine(s1 + s2);
        }
    }
}
