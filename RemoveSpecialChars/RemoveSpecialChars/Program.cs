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
            string[] chars = new string[] { ",", ".", "/", "!", "@", "#", "$", "%", "^", "&", "*", "'", "\"", ";", "_", "(", ")", ":", "|", "[", "]" };
            
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
