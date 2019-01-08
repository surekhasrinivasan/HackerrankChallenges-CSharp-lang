using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpStatements
{
    // Jump statements are used to jump to a particular position in a program. Break, Continue, goto and Return are the jump statements
    
    // Program to show Jump statements 
    class Program
    {
        static void Main(string[] args)
        {
            // Break is used to terminate the loop and switch statement
            for(int i = 1; i <=10; i++)
            {
                if (i == 5)
                    break;
                Console.WriteLine("i is: " + i);
            }

            // Continue forces the next iteration of the loop to take place, 
            // skipping any code in between

            // Continue can be used only inside a loop 
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5 || i == 7)
                    continue;
                Console.WriteLine("i is: " + i);
            }
        }
    }
}
