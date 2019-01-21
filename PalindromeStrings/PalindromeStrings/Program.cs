using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeStrings
{
    // Program to find out if the string is palindromic or not

    // A palindrome has the same letters on both ends of the string. ex: kayak, malayalam
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a word: ");
            string word = Console.ReadLine();

            var array = word.ToCharArray();
            Array.Reverse(array);

            if (word.Equals(new string(array)))
            {
                Console.WriteLine(word + " is Palindrome");
            }
            else
            {
                Console.WriteLine(word + " is not Palindrome");
            }
        }
    }
}
