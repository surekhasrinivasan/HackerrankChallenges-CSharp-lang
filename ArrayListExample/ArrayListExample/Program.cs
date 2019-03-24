using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListExample
{
    // Program to demo ArrayList Methods 
    class Program
    {
        static void Main(string[] args)
        {
            // Add Method
            ArrayList list = new ArrayList();
            list.Add("Csharp");
            list.Add("Javascript");
            list.Add("Java");
            list.Add("Ruby");

            ArrayListExamples(list);
        }

        static void ArrayListExamples(ArrayList list)
        {
            foreach(string i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
