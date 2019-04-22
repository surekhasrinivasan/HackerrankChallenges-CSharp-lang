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

            Console.WriteLine(TargetSum.TwoIntegersSumToTarget(arr, target));            
        }
    }
}
