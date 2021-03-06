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

            // Usage of string.format() method to convert a value
            DateTime datetime = new DateTime( 2019, 1, 12, 10, 35, 40 );
            string strdatetime = String.Format("Message sent at {0:t} on {0:D}", datetime);
            Console.WriteLine("Message: {0}", strdatetime);

            // Usage of .ToUpper() and .ToLower() methods
            string str = "This is the City of Boston";

            string up = str.ToUpper();
            Console.WriteLine(up);

            string lower = str.ToLower();
            Console.WriteLine(lower);

            // Usage of .StartsWith() and .EndsWith()
            Console.WriteLine(str.StartsWith("Th"));

            Console.WriteLine(str.EndsWith("on"));

            // Usage of .Contains method
            Console.WriteLine(str.Contains("Boston"));

            // Usage of .IndexOf method
            Console.WriteLine(str.IndexOf("Th", StringComparison.CurrentCultureIgnoreCase));

            Console.WriteLine(str.IndexOf("th", 3, StringComparison.CurrentCultureIgnoreCase));

            // To find the length of the string using .Length property
            Console.WriteLine(str.Length);

            // String vs. StringBuilder

            // Strings are immutable.  

            string str1 = "Las";
            str1 = str1 + "Vegas";

            Console.WriteLine(str1);

            // StringBuilder is mutable. 
            string str2 = "Las";
            StringBuilder sb = new StringBuilder(str2);
            sb.Append("Vegas");

            Console.WriteLine(sb);
        }
    }
}
