using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveSpecialChars
{
    // Program to remove special characters from a given string
    class Program
    {
        static void Main(string[] args)
        {
            string str = "$c!sh$arp&la%ng#u,a^g@e";
            Console.WriteLine(RemoveSpecialCharacters(str));
        }

        public static string RemoveSpecialCharacters(string str)
        {
            // Create  a string array and add the special characters you want to remove
            string[] chars = new string[] { ",", ".", "/", "!", "@", "#", "$", "%", "^", "&", "*", "'", "\"", ";", "_", "(", ")", ":", "|", "[", "]" };

            //Iterate the number of times based on the String array length
            for (int i = 0; i < chars.Length; i++)
            {
                if (str.Contains(chars[i]))
                {
                    str = str.Replace(chars[i], "");
                }
            }
            return str;
        }
    }
}
