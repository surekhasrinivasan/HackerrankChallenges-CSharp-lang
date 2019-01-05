using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringChallenge2
{
    // Coding Challenge - Compare Strings

    /**
     * Create the following function/method:

     * functionName(string, string, length)
     * function should return an array of integers the length of the string
     * function is comparing how to change the first word into the second word by returning the number of steps each character must take to become the character of the other string.
     * Example:
        function("this", "that", 4) = [0, 0, -8, 1]
        function('this', bear', 4) = [-18, -3, -8, -1]
        function('"bear", 'this", 4) = [18, 3, 8, 1]
     * Also return the total change score. This should add together the changes in the array to give a total change score
       function("bear", "this", 4) = 25
     * */
     
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string str1 = Console.ReadLine();

            Console.WriteLine("Enter another string: ");
            string str2 = Console.ReadLine();

            Console.WriteLine("Enter the string length: ");
            int length = int.Parse(Console.ReadLine());

            if (str1.Length != str2.Length)
            {
                Console.WriteLine("Both strings should be of same length");
                return;
            }
        }
    }
}
