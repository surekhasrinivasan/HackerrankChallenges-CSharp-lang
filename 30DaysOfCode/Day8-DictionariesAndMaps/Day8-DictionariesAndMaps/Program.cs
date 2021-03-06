﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_DictionariesAndMaps
{
    /*
     * Given n names and phone numbers, assemble a phone book that maps friends' names to their respective phone numbers. 
     * You will then be given an unknown number of names to query your phone book for. For each name queried, 
     * print the associated entry from your phone book on a new line in the form name=phoneNumber; 
     * if an entry for name is not found, print Not found instead.

     * Note: Your phone book should be a Dictionary/Map/HashMap data structure.
     * */

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the number of Entries: ");
            //int n = int.Parse(Console.ReadLine());
            //string name;

            //Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            //for(int i =0; i < n; i++)
            //{
            //    var temp = Console.ReadLine().Split(' ');
            //    phoneBook.Add(temp[0], temp[1]);
            //}
            //while((name = Console.ReadLine()) != null)
            //{
            //    if (phoneBook.ContainsKey(name))
            //    {
            //        Console.WriteLine(name + "=" + phoneBook[name]);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Not found");
            //    }
            //}

            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            phoneBook.Add("Sam", "12345678");
            phoneBook.Add("Smith", "23456789");
            phoneBook.Add("Rob", "34567890");
            phoneBook.Add("John", "45678901");

            // ContainsKey can be used to test keys before inserting them.
            if (!phoneBook.ContainsKey("Marie"))
            {
                phoneBook.Add("Marie", "56789012");
            }

            foreach(KeyValuePair<string, string> kvp in phoneBook)
            {
                Console.WriteLine("{0} = {1}", kvp.Key, kvp.Value);
            }
        }
    }
}
