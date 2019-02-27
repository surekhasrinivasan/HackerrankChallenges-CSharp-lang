using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_AbstractClasses
{
    abstract class Book
    {

        protected String title;
        protected String author;

        public Book(String t, String a)
        {
            title = t;
            author = a;
        }
        public abstract void display();


    }

    /*
     * Given a Book class and a Solution class, write a MyBook class that does the following:

      * Inherits from Book
      * Has a parameterized constructor taking these 3 parameters:
        1. string title
        2. string author
        3. int price
      * Implements the Book class' abstract display() method so it prints these 3 lines:
        1. Title:, a space, and then the current instance's title.
        2. Author:, a space, and then the current instance's author.
        3. Price:, a space, and then the current instance's price.
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
