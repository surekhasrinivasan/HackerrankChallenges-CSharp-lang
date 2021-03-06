﻿using System;
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
            //// Example for Finally if exception is handled
            //try
            //{
            //    int a = 10;
            //    int b = 0;
            //    int x = a / b;
            //}
            //catch (Exception e) { Console.WriteLine(e); }
            //finally { Console.WriteLine("Finally block is executed"); }
            //Console.WriteLine("Rest of the code");

            // Example for Finally if exception is not handled
            try
            {
                int a = 10;
                int b = 0;
                int x = a / b;
            }
            catch (NullReferenceException e) { Console.WriteLine(e); }
            finally { Console.WriteLine("Finally block is executed"); }
            Console.WriteLine("Rest of the code");
        }
    }
}
