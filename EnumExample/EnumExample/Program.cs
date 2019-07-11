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

        public static string GetGender(Gender gender)
        {
            // The switch here is now more readable and maintainable because
            // of replacing the integral numbers with Gender enum
            switch (gender)
            {
                case Gender.Unknown:
                    return "Unknown";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "Invalid Data for Gender";
            }
        }
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

