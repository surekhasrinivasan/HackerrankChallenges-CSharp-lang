using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_Inheritance
{
    class Person
    {
        protected string firstName;
        protected string lastName;
        protected int id;

        public Person() { }
        public Person(string firstName, string lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }
        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        }
    }

    /*
     * You are given two classes, Person and Student, where Person is the base class and Student is the derived class. 
     * Completed code for Person and a declaration for Student are provided for you in the editor. 
     * Observe that Student inherits all the properties of Person.

     * Complete the Student class by writing the following:

        A Student class constructor, which has 4 parameters:
        A string, firstName.
        A string, lastName.
        An integer, id.
        An integer array (or vector) of test scores, scores.

        A char calculate() method that calculates a Student object's average and returns the grade character representative of their calculated average:
     **/

    class Student : Person
    {
        private int[] testScores;
        /*	
        *   Class Constructor
        *   
        *   Parameters: 
        *   firstName - A string denoting the Person's first name.
        *   lastName - A string denoting the Person's last name.
        *   id - An integer denoting the Person's ID number.
        *   scores - An array of integers denoting the Person's test scores.
        */
        // Write your constructor here
        public Student() { }
        public Student(string firstName, string lastName, int id, int[] testScores)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
            this.testScores = testScores;
        }

        /*	
        *   Method Name: Calculate
        *   Return: A character denoting the grade.
        */
        // Write your method here


    }

    // Main method
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
