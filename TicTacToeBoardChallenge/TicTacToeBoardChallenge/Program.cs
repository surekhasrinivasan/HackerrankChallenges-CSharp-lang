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
            int rows = 2;

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine(" | | ");
                Console.WriteLine("-+-+-");

            }
            Console.WriteLine(" | | ");
        }
    }    
}
