using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVsInstance
{
    class Program
    {
        // Classes Vs. Instance

        /*
         * Write a Person class with an instance variable, age, and a constructor that takes an integer, initialAge, as a parameter. 
         * The constructor must assign initialAge to age after confirming the argument passed as initialAge is not negative; 
         * if a negative argument is passed as initialAge, the constructor should set age to 0 and print Age is not valid, setting age to 0.. 
         * In addition, you must write the following instance methods:

        1. yearPasses() should increase the age instance variable by 1.
        2. amIOld() should perform the following conditional actions:
            If age < 13, print You are young..
            If age >=13 and age < 18, print You are a teenager..
            Otherwise, print You are old..
        */
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter age: ");
            int age = int.Parse(Console.ReadLine());
            Person p = new Person(age);
            p.amIOld();
            for (int j = 0; j < 3; j++)
            {
                p.yearPasses();
            }
            p.amIOld();
            Console.WriteLine();
        }


        public class Person
        {
            public int age;

            public Person(int initialAge)
            {
                // Add some more code to run some checks on initialAge
                age = initialAge;               
            }

            public int getAge()
            {
                return this.age;
            }

            public void setAge(int age)
            {
                this.age = age;
            }

            public void amIOld()
            {
                // Do some computations in here and print out the correct statement to the console 
                if (this.age < 0)
                {
                    age = 0;
                    Console.WriteLine("Age is not valid, setting age to 0.");
                }
                else if (this.age < 13)
                {
                    Console.WriteLine("You are young.");
                }
                else if(this.age >= 13 && this.age < 18)
                {
                    Console.WriteLine("You are a teenager.");
                }
                else
                {
                    Console.WriteLine("You are old.");
                }
            }

            public void yearPasses()
            {
                // Increment the age of the person in here
                setAge(getAge() + 1);
            }
        }
    }
}
