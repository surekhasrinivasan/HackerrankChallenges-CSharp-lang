using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseCharacters
{
    // Program to print the characters in a string in the reverse order.
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the string
            Console.WriteLine("Please enter your string: ");

            // Read the user string from console
            string userString = Console.ReadLine();

            // The simple way to reverse a string is to use
            // the built-in .net framework Reverse() function
            List<char> StringChars = userString.Reverse().ToList();

            // Finally print each character from the collection
            foreach(char c in StringChars)
            {
                Console.Write(c);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
