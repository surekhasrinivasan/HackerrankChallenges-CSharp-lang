using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowersOfHanoi
{
    /* Tower of Hanoi is a mathematical game or puzzle. It consists of three rods(towers), and a 
     * number of disks of different sizes which can slide onto any rod. The puzzle starts with the 
     * disks in a neat stack in ascending order of size on one rod, the smallest at the top, thus 
     * making a conical shape.
     * 
     * The objective of the puzzle is to move the entire stack to another rod, obeying the following simple rules:
     * 
     * Only one disk can be moved at a time.
     * 
     * Each move consists of taking the upper disk from one of the towers and placing it on top of another 
     * tower i.e. a disk can only be moved if it is the uppermost disk on a tower.
     * 
     * No disk may be placed on top of a smaller disk.
     */
    class Program
    {
        static void Main(string[] args)
        {
            //Solving the Towers of Hanoi challenge using Recursion
            char startPeg = 'A';
            char endPeg = 'C';
            char tempPeg = 'B';
            int totalDisks = 3;

            SolveTowers(totalDisks, startPeg, endPeg, tempPeg);

        }

        public static void SolveTowers(int n, char startPeg, char endPeg, char tempPeg)
        {
            if(n > 0)
            {
                SolveTowers(n - 1, startPeg, tempPeg, endPeg);
                Console.WriteLine("Move disk from " + startPeg + " to " + endPeg);
                SolveTowers(n - 1, tempPeg, endPeg, startPeg);
            }
        } 
    }
}
