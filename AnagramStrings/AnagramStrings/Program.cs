using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramStrings
{
    // Program to show if two strings are anagram to each other.

    // Two strings or words are said to be Anagrams of each other if they share the same set of letters to form the respective words.
    // for an example: Silent–>Listen, post–>opts.
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a word: ");
            string str1 = Console.ReadLine();

            Console.WriteLine("Enter another word: ");
            string str2 = Console.ReadLine();

            char[] char1 = str1.ToLower().ToCharArray();
            char[] char2 = str2.ToLower().ToCharArray();

            Array.Sort(char1);
            Array.Sort(char2);

            string newstr1 = new string(char1);
            string newstr2 = new string(char2);

            if(newstr1 == newstr2)
            {
                Console.WriteLine("strings {0} and {1} are Anagrams", str1, str2);
            }
            else
            {
                Console.WriteLine("strings {0} and {1} are not Anagrams", str1, str2);
            }


        }

    }
}
