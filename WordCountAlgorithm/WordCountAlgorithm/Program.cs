using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCountAlgorithm
{
    // Count the number of words in a string
    class Program
    {
        static void Main(string[] args)
        {
            int result = WordCount("I like to solve this is a word count algorithm");
            Console.WriteLine(result);            
        }

        //public static int WordCount(string str)
        //{
        //    int count = 0;

        //    if (!string.IsNullOrWhiteSpace(str))
        //    {
        //        foreach(string s in str.Split(' '))
        //        {
        //            count++;
        //        }
        //    }
        //    return count;
        //}

        // Another variation
        public static int WordCount(string str)
        {
            int count = 0;
            
            if(str == " ")
            {
                return 0;
            }

            while (str.Contains("  "))
                str = str.Replace("  ", " ");

            foreach(string s in str.Split(' '))
            {
                count++;
            }

            return count;
        }
    }
}
