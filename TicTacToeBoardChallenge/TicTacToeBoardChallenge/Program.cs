using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeBoardChallenge
{
    // Write the code to display Tic Tac Toe Board 5 X 5 size
    class Program
    {
        static void Main()
        {
            //int rows = 2;

            //for (int i = 0; i < rows; i++)
            //{
            //    Console.WriteLine(" | | ");
            //    Console.WriteLine("-+-+-");

            //}
            //Console.WriteLine(" | | ");

            // Another version 
            //int rows = 5;

            //for (int i = 0; i < rows; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(" | | ");
            //    }
            //    else
            //    {
            //        Console.WriteLine("-+-+-");
            //    }
            //}

            // Printing characters inside each cell
            int rows = 4;

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine("o|x|o");
                Console.WriteLine("-+-+-");

            }
            Console.WriteLine("x|o|x");
        }
    }    
}