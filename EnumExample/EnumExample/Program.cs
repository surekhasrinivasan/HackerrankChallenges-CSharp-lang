using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    // Program to demo usage of Enum
    class Program
    {
        static void Main(string[] args)
        {
        }

        public enum Gender
        {
            Unknown = 0,
            Male = 1,
            Female = 2
        }

        public class Customer
        {
            public string Name { get; set; }
            public Gender Gender { get; set; }
        }
    }
}
