using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetSumChallenge
{
    // Given an integer and an array of integers determine whether any two integers in the array sum to that integer.
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };
            int target = 5;

            Console.WriteLine("Sum of two integers in an array is equal to target integer true/false: ");
            Console.WriteLine(TargetSum.TwoIntegersSumToTarget(arr, target));

            int[] arr2 = { 3, 4, 5, 6 };
            int targetInt = 13;

            Console.WriteLine("Sum of two integers in an array is equal to target integer true/false: ");
            Console.WriteLine(TargetSum.TwoIntegersSumToTarget(arr2, targetInt));
        }
    }
}
