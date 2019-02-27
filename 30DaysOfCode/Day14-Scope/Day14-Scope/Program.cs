using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_Scope
{
    /*Complete the Difference class by writing the following:
     * 
     * A class constructor that takes an array of integers as a parameter and saves it to the elements instance variable.
     * 
     * A computeDifference method that finds the maximum absolute difference between any 2 numbers in N and stores it 
     * in the maximumDifference instance variable.
     * 
     */
     
    class Difference
    {
        private int[] elements;
        public int maximumDifference;

        // Add your code here
        public Difference(int[] a)
        {
            elements = a;
        }

        public int computeDifference()
        {
            return maximumDifference = Math.Abs(elements.Max() - elements.Min());
        }

    } // End of Difference Class

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements in an array: ");
            Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the array elements: ");
            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.WriteLine("The absolute maximum difference is: " + d.maximumDifference);
        }
    }
}
