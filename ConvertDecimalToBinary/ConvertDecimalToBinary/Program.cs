using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDecimalToBinary
{
    // Program to convert Decimal number to Binary number
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a decimal number: ");
            int decimalNumber = Convert.ToInt32(Console.ReadLine());
            int quotient;
            string remainder = " ";
            while(decimalNumber >= 1)
            {
                quotient = decimalNumber / 2;
                remainder += (decimalNumber % 2).ToString();
                decimalNumber = quotient;
            }
            string binaryNum = " ";
            for(int i = remainder.Length - 1; i >=0; i--)
            {
                binaryNum = binaryNum + remainder[i];
            }
            Console.WriteLine("The Binary number format for a given number is: {0}", binaryNum);
            Console.Read();
        }
    }
}
