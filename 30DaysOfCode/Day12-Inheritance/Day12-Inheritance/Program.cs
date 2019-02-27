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
        public char Calculate()
        {
            char grade = 'O';
            int avgGrade = 0, tScores = 0;

            for (int i = 0; i < testScores.Length; i++)
            {
                int input = testScores.Length;
                tScores += testScores[i];
                avgGrade = tScores / input;
            }
            if (avgGrade >= 90 && avgGrade <= 100)
            {
                grade = 'O';
            }
            else if (avgGrade >= 80 && avgGrade < 90)
            {
                grade = 'E';
            }
            else if (avgGrade >= 70 && avgGrade < 80)
            {
                grade = 'A';
            }
            else if (avgGrade >= 55 && avgGrade < 70)
            {
                grade = 'P';
            }
            else if (avgGrade >= 40 && avgGrade < 55)
            {
                grade = 'D';
            }
            else if (avgGrade < 40)
            {
                grade = 'T';
            }
            return grade;
        }
    }

    // Main method
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first name, last name and id: ");
            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);

            Console.WriteLine("Enter number of scores: ");
            int numScores = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the scores values: ");
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.Calculate() + "\n");
        }
    }
}
