using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    // Example program to break a String down into its component characters, we can use the String.toCharArray method
    class Program
    {
        static void Main(string[] args)
        {
            string mystr = "I see an apple on the tree.";
            char[] myCharArray = mystr.ToCharArray();
            
            for(int i = 0; i < mystr.Length; i++)
            {
                // Print each sequential character on the same line. 
                Console.Write(myCharArray[i]);                
            }
            
            // Prints a new line
            Console.WriteLine();
        }
    }
}
