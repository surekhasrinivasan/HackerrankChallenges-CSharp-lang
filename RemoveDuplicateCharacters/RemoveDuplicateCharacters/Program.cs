using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicateCharacters
{
    // Program removes duplicate chars using string concats.
    class Program
    {
        static void Main(string[] args)
        {
            string value1 = RemoveDuplicateCharacters("Csharpstar");
            string value2 = RemoveDuplicateCharacters("Google");
            string value3 = RemoveDuplicateCharacters("Yahoo");
            string value4 = RemoveDuplicateCharacters("CNN");
            string value5 = RemoveDuplicateCharacters("Line1\nLine2\nLine3");

            Console.WriteLine(value1);
            Console.WriteLine(value2);
            Console.WriteLine(value3);
            Console.WriteLine(value4);
            Console.WriteLine(value5);
        }
        
        static string RemoveDuplicateCharacters(string key)
        {
            // Store encountered letters in this string
            string table = "";

            // Store the result in this string
            string result = "";

            // Loop over each character
            foreach(char value in key)
            {
                // See if character is in the table 
                if(table.IndexOf(value) == -1)
                {
                    // Append to the table and the result
                    table += value;
                    result += value;
                }
            }
            return result;
        }
    }
}
