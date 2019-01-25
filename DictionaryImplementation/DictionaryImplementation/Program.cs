using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryImplementation
{
    // Program to demonstrate Dictionary 

    /*
     * The Dictionary in C# is a collection of Keys and Values, where key is like word and value is like definition.
     * 
     * The Dictionary<TKey, TValue> class is a generic collection class in the System.Collection.Generics namespace. 
     * TKey denotes the type of key and TValue is the type of TValue.
     * */
    class Program
    {
        static void Main(string[] args)
        {
            var Books = new Dictionary<int, string>()
            {
                {1, "Science" },
                {2, "Math" },
                {3, "History" },
                {4, "ELA" },
                {5, "Music" }
            };

            foreach(KeyValuePair<int, string> keyValuePair in Books)
            {
                Console.WriteLine(keyValuePair.Key + " : " + keyValuePair.Value);
            }
            Console.ReadLine();
        }
    }
}
