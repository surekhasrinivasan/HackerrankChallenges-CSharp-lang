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

            string resultStr2 = ReverseStr("City of Boston");
            Console.WriteLine(resultStr2);
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
