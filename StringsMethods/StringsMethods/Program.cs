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

            string fullname = fname + " " + lname;
            Console.WriteLine("Full Name: {0}", fullname);            
        }
    }
}
