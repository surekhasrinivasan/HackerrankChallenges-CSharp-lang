using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_Exceptions_StringToInteger
{
    // Task
    
    // Read a string, S, and print its integer value; if S cannot be converted to an integer, print Bad String.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            String S = Console.ReadLine();

            try
            {
                int s = Convert.ToInt32(S);
                Console.WriteLine(s);
            }
            catch(Exception)
            {
                Console.WriteLine("Bad String");
            }
        }
    }
}
