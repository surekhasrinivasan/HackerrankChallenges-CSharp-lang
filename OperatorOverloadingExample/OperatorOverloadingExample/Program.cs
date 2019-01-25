using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingExample
{
    // Program to demonstrate Operator Overloading
    class Length
    {
        int feet, inch;
        public Length()
        {
            this.feet = 0;
            this.inch = 0;
        }
        public Length(int feet, int inch)
        {
            this.feet = feet;
            this.inch = inch;
        }

        string GetLength()
        {
            return String.Format("Length: {0}' {1}\"", feet, inch);
        }
        static void Main(string[] args)
        {
            Length len1 = new Length(2, 8);
            Length len2 = new Length(4, 5);

            Console.WriteLine(len1.GetLength());
            Console.WriteLine(len2.GetLength());
        }
    }
}
