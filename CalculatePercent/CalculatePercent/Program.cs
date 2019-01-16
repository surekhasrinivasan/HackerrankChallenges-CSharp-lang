using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatePercent
{
    // Demo program to show implentation of class 
    class Test
    {
        int marks;
        void CalculatePercent()
        {
            int percent = marks * 100 / 50;
            Console.WriteLine(percent);
        }

        static void Main(string[] args)
        {
            Test t1 = new Test();
            t1.marks = 43;
            t1.CalculatePercent();


            Test t2 = new Test();
            t2.marks = 38;
            t2.CalculatePercent();
        }
    }    
}
