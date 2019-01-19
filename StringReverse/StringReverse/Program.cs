using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverse
{
    // Program to reverse a string
    class Program
    {
        static void Main(string[] args)
        {
            string resultStr = ReverseStr("This is a cat.");
            Console.WriteLine(resultStr);
        }

        public static string ReverseStr(string str)
        {
            string result = "";
            for(int i = str.Length-1; i >= 0; i--)
            {
                result += str[i];
            }
            return result;
        }
    }
}
