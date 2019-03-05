﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19_Interfaces
{
    /* Task
     * The AdvancedArithmetic interface and the method declaration for the abstract divisorSum(n) method are 
     * provided for you in the editor below.
     * Complete the implementation of Calculator class, which implements the AdvancedArithmetic interface. 
     * The implementation for the divisorSum(n) method must return the sum of all divisors of n.
     */

    public interface AdvancedArithmetic
    {
        int divisorSum(int n);
    }

    public class Calculator : AdvancedArithmetic
    {
        public int divisorSum(int n)
        {
            int sum = 0;
            for(int i =1; i <= n; i++)
            {
                if(n % i == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer: ");
            int n = Int32.Parse(Console.ReadLine());
            AdvancedArithmetic myCalculator = new Calculator();
            int sum = myCalculator.divisorSum(n);
            Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
        }
    }
}