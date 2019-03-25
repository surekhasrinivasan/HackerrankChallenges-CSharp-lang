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
            ArrayListExamples1();
        }

        // Pass ArrayList as Argument
        static void ArrayListExamples(ArrayList list)
        {
            Console.WriteLine("Elements in the list: ");
            foreach(string i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }

        // Return ArrayList 
        static ArrayList ArrayListExamples1()
        {
            ArrayList list2 = new ArrayList();
            list2.Add("HTML");
            list2.Add("CSS");
            list2.Add("JavaScript");
            list2.Add("React");

            Console.WriteLine("Elements in the list2: ");
            foreach (string i in list2)
            {
                Console.WriteLine(i);
            }
            return list2;
        }
    }
}
