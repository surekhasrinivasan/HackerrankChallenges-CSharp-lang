using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyStatement
{
    // Program to demo Empty statement.

    // Empty statements are those that does not contain anything other than a semicolon(;)s   
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int i = 0;
    //        Program p = new Program();
    //        while (p.Print())
    //        {
    //            ; // Empty statement
    //        }
    //        Console.WriteLine("i = {0}", i);
    //        Console.ReadLine();
    //    }

    //    public bool Print()
    //    {
    //        Console.WriteLine("CSharp");
    //        return true;
    //    }
    //}

    // Example - 2 Use an Empty statement as the body of the while loop
    class Program
    {
        static void Main()
        {
            while (Method())
            {
                ; // Empty statement
            }

        }
        static int num;

        static bool Method()
        {
            // Write the number, increment and then return a bool
            Console.WriteLine(num);
            num++;
            return num < 10;
        }
    }

}
