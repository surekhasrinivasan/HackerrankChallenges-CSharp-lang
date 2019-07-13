using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumberAlgorithm
{
    // Program to check whether the number is Armstrong or not. 

    // Armstrong number is a number that is equal to the sum of cubes of its digits. 
    // For example 0, 1, 153, 370, 371 and 407 are the Armstrong numbers.
    class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0, remainder, temp; 

            // Prompt user for the input number
            Console.WriteLine("Enter the number: ");

            // Convert the string to integer
            num = Convert.ToInt32(Console.ReadLine());

            temp = num;

            while(num > 0)
            {
                remainder = num % 10;

                sum = sum + (remainder * remainder * remainder);

                num = num / 10;
            }
            if(sum == temp)
            {
                Console.WriteLine("Armstrong Number");
            }
            else
            {
                Console.WriteLine("Not Armstrong Number");
            }            
        }
    }
}
