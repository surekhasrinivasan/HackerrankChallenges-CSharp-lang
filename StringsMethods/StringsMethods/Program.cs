using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsMethods
{
    // Program to show usage of different methods of String class
    class Program
    {
        static void Main(string[] args)
        {
            string fname, lname;
            fname = "Surekha";
            lname = "Srinivasan";

            // String concatination
            string fullname = fname + " " + lname;
            Console.WriteLine("Full Name: {0}", fullname);

            // Usage of string.concat()method
            string fullName = string.Concat(fname, lname);
            Console.WriteLine("Full Name: {0}", fullName);

            // Usage of string constructor 
            // convert character array to string 
            char[] letters = { 'S', 'U', 'R', 'E', 'K', 'H', 'A' };
            string hello = new string(letters);
            Console.WriteLine("Hello : {0}", hello);

            // convert string to character array
            char[] ch = hello.ToCharArray();
            Console.WriteLine(ch);

            // Usage of string.join() method
            string[] strarr = { "Hello", "from", "Surekha", "Srinivasan" };
            string message = String.Join(" ", strarr);
            Console.WriteLine("Message: {0}", message);
        }
    }
}
