using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubStringsInString
{
    // Program to find all the substrings in a string
    class Program
    {
        static void Main(string[] args)
        {
            string str = "apple";

            for(int i = 1; i < str.Length; i++)
            {
                for(int start = 0; start <= str.Length - i; start++)
                {
                    string substring = str.Substring(start, i);
                    Console.WriteLine(substring);
                }
            }
        }
    }
}
