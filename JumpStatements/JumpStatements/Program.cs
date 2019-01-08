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
            //for(int i = 1; i <=10; i++)
            //{
            //    if (i == 5)
            //        break;
            //    Console.WriteLine("i is: " + i);
            //}

            // Continue forces the next iteration of the loop to take place, 
            // skipping any code in between

            // Continue can be used only inside a loop 
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i == 5 || i == 7)
            //        continue;
            //    Console.WriteLine("i is: " + i);
            //}

            // goto - provides an unconditional jump from the 'goto'
            // to a labeled statement in the same function. Make sure
            // Switch and goto statments are in there in the same method

            //int i = 1;

            ////label
            //abc:
            //    Console.WriteLine(i);
            //    i++;
            //if (i <= 10)
            //    goto abc;

            // return - used to terminate the method and return the control to the calling method.

            Console.WriteLine("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            if(num2 == 0)
            {
                Console.WriteLine("Cannot divide a number by 0");
                return;
            }

            int result = num1 / num2;
            Console.WriteLine("Result is: " + result);
        }
    }
}
