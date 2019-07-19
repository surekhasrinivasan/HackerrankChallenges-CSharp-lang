using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleForFinally
{
    // Program to demo Finally
    class Program
    {
        static void Main(string[] args)
        {
            // Example for Finally if exception is handled
            try
            {
                int a = 10;
                int b = 0;
                int x = a / b;
            }
            catch (Exception e) { Console.WriteLine(e); }
            

            
        }
    }
}
