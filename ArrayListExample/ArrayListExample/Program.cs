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

            ArrayList list3 = new ArrayList();
            list3.Add("PHP");
            list3.Add("C");
            list3.Add("C++");

            ArrayListExamples(list);
            ArrayListExamples1();
                       
            // ArrayList AddRange Method
            list.AddRange(list3);

            Console.WriteLine("Elements in the list after AddRange Method: ");
            foreach(string i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // ArrayList Count and Clear Method
            Console.WriteLine("Number of elements in list3: " + list3.Count);
            list3.Clear();
            Console.WriteLine("Number of elements in list3 after Clear method : " + list3.Count);

            // sort the ArrayList and print to console
            list.Sort();

            Console.WriteLine();
            Console.WriteLine("Sorted ArrayList: ");
            foreach(string i in list)
            {
                Console.WriteLine(i);
            }

            // Reverse the ArrayList and print to Console
            list.Reverse();

            Console.WriteLine();
            Console.WriteLine("Reverse list: ");
            foreach(string i in list)
            {
                Console.WriteLine(i);
            }

            // Clone Method creates a copy of all the elements of the ArrayList
            list.Clone();

            Console.WriteLine();
            Console.WriteLine("The shallow copy of arraylist is: ");
            foreach(string i in list)
            {
                Console.WriteLine(i);
            }

            // ArrayList Contains Method
            Console.WriteLine();
            Console.WriteLine("Element CSharp is in the ArrayList: {0}", list.Contains("Csharp"));
            Console.WriteLine("Element C+ is in the ArrayList: {0}", list.Contains("C+"));
            Console.WriteLine("Element Java is in the ArrayList: {0}", list.Contains("Java"));
            Console.WriteLine();  

            // ArrayList Insert Method
            list.Insert(0, "CsharpInsert");
            list.Insert(3, "TechInsert");

            Console.WriteLine();
            Console.WriteLine("Elements in the ArrayList after Insert method: ");
            foreach(string i in list)
            {
                Console.WriteLine(i);
            }

            // ArrayList InsertRange Method
            ArrayList list4 = new ArrayList();

            list4.Add("MySQL");
            list4.Add("PHP");
            list.InsertRange(3, list4);
            Console.WriteLine("Elements in the ArrayList after InsertRange Method: ");
            foreach(string i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // ArrayList Remove Method
            list.Remove("Java");

            Console.WriteLine("Elements in the ArrayList after Remove Method: ");
            foreach(string i in list)
            {
                Console.WriteLine(i);
            }

            // ArrayList RemoveAt Method
            list.RemoveAt(1);

            Console.WriteLine();
            Console.WriteLine("Elements in the ArrayList after RemoveAt Method: ");
            foreach (string i in list)
            {
                Console.WriteLine(i);
            }

            // ArrayList RemoveRange Method
            list.RemoveRange(1, 2);

            Console.WriteLine();
            Console.WriteLine("Elements in the ArrayList after RemoveRange Method: ");
            foreach (string i in list)
            {
                Console.WriteLine(i);
            }

            // ArrrayList GetRange Method
            ArrayList list5 = list.GetRange(1, 3);

            Console.WriteLine();
            Console.WriteLine("Elements in the ArrayList5 after GetRange Method: ");
            foreach(string i in list5)
            {
                Console.WriteLine(i);
            }


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
            Console.WriteLine();
            return list2;
        }
    }
}
