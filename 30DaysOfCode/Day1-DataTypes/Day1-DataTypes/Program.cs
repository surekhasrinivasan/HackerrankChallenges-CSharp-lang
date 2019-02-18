using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_DataTypes
{
    // Print the sum of both integers on the first line, the sum of both doubles (scaled to 1 decimal place) 
    // on the second line, and then the two concatenated strings on the third line.
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            // Declare second integer, double, and String variables.
            int num;
            double doubleNum;
            string str;

            // Read and save an integer, double, and String to your variables.
            num = Convert.ToInt16(Console.ReadLine());
            doubleNum = Convert.ToDouble(Console.ReadLine());
            str = Console.ReadLine();

            // Print the sum of both integer variables on a new line.
            Console.WriteLine(i + num);

            // Print the sum of the double variables on a new line.
            double sum = d + doubleNum;
            Console.WriteLine(String.Format("{0:0.0}", sum));

            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine(s + str);
        }
    }
}
