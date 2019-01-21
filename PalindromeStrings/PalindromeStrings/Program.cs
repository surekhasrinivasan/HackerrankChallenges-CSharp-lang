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
        public static bool IsPalindrome(string word)
        {
            int min = 0;
            int max = word.Length - 1;

            while (true)
            {
                if(min > max)
                {
                    return true;
                }
                char a = word[min];
                char b = word[max];
                if(char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }

        static void Main()
        {
            //Console.WriteLine("Enter a word: ");
            //string word = Console.ReadLine();

            //// Convert the word to char array 
            //var array = word.ToCharArray();

            //// Reverse the array
            //Array.Reverse(array);

            //if (word.Equals(new string(array)))
            //{
            //    Console.WriteLine(word + " is Palindrome");
            //}
            //else
            //{
            //    Console.WriteLine(word + " is not Palindrome");
            //}

            // Another version
            string[] array = {"civic", "deleveled", "Hannah", "kayak", "level", "examiron", "racecar", "radar", "refer", "reviver",
                               "easywcf", "rotator", "rotor", "sagas", "solos", "stats", "tenet", "Csharpstar", ""};
            foreach (string word in array)
            {
                Console.WriteLine("{0} = {1}", word, IsPalindrome(word));
            }
        }
    }
}
