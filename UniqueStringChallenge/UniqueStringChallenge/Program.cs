using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueStringChallenge
{
    // Implement an algorithm to determine if a string has all unique characters.    
    class Program
    {
        public static bool IsUnique(string str)
        {
            string temp1 = "";
            string temp2 = "";

            for (int i = 0; i < str.Length; i++)
            {
                temp1 = str.Substring(i, 1);

                for (int k = 0; k < str.Length; k++)
                {
                    temp2 = str.Substring(k, 1);
                    if ((temp1 == temp2) && (i != k))
                        return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsUnique("Samarth"));
            Console.WriteLine(IsUnique("Smith"));
        }
    }
}
