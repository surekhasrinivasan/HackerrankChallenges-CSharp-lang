﻿using System;
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
            // Create the array
            string[] array = { "Mongo", "Express", "Angular", "Node" };
            Console.WriteLine("Enter the elements of the array: ");
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine();
            // Convert Array into ArrayList
            ArrayList arrayList = new ArrayList(array);

            Console.WriteLine("The elements in the arrayList that are copied from array: ");
            foreach(string s in arrayList)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            // Add Method
            ArrayList list = new ArrayList();
            list.Add("Csharp");
            list.Add("Javascript");
            list.Add("Java");
            list.Add("Ruby");

            // Convert an ArrayList to Array
            // Create an Array
            string[] strArray = list.ToArray(typeof(string)) as string[];
            Console.WriteLine();
            Console.WriteLine("ArrayList elements are copied to array");
            Console.WriteLine("The elements of the array are: ");
            foreach(string value in strArray)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();

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
            Console.WriteLine();

            // ArrayList BinarySearch Method
            Console.WriteLine("The element Javascript searched at: " + list.BinarySearch("Javascript"));
            Console.WriteLine("The element Csharp searched at: " + list.BinarySearch("Csharp"));

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

            // ArrayList SetRange Method
            ArrayList list6 = new ArrayList();
            list6.Add("MSDN");

            list.SetRange(2, list6);
            Console.WriteLine();
            Console.WriteLine("Elements in the ArrayList after SetRange Method: ");
            foreach(string i in list)
            {
                Console.WriteLine(i);
            }

            // ArrayList IndexOf Method
            Console.WriteLine();
            Console.WriteLine("The index value of CsharpInsert: " + list.IndexOf("CsharpInsert"));
            Console.WriteLine("The index value of PHP: "+ list.IndexOf("PHP"));
            Console.WriteLine("The index value of Javascript: " + list.IndexOf("Javascript"));
            Console.WriteLine("The index value of C++: " + list.IndexOf("C++"));

            // ArrayList Synchronized Method
            
            // Creates a synchronized arraylist
            ArrayList list7 = ArrayList.Synchronized(list);

            // Displays whether the ArrayList is Synchronized or not
            Console.WriteLine();
            Console.WriteLine("ArrayList Synchronized or not: ");
            Console.WriteLine("ArrayList list is: {0}", list.IsSynchronized ? "Synchronized" : "Not-Synchronized");
            Console.WriteLine("ArrayList list is: {0}", list7.IsSynchronized ? "Synchronized" : "Not-Synchronized");
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
