using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day0_HelloWorld
{
    // Prgram to print Hello World 
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a string variable which takes input from user
            string input_string;

            // Take input from user 
            Console.WriteLine("Enter a string: ");
            input_string = Console.ReadLine();

            // Print string literal "Hello World"
            Console.WriteLine("Hello World");

            // print the user input 
            Console.WriteLine(input_string);
        }
    }
}
