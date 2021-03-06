﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    class Program
    {
        /* C# implementation of moving zeros to end of an array
         * 
         * Given an array nums, write a function to move all 0's to the end of it while maintaining 
         * the relative order of the non-zero elements.
         * For example, given nums = [0, 1, 0, 3, 12], after calling your function, nums should be [1, 3, 12, 0, 0].
         * Note:
         * You must do this in-place without making a copy of the array.
         * Minimize the total number of operations.
         */
        static void Main(string[] args)
        {
            int[] nums = { 5, 0, 2, 0, 9, 3, 0, 5, 6 };

            Console.WriteLine("The integer array after implementing MoveZerosToEnd method: ");
            for(int i = 0; i < nums.Length; i++)
            {
                MoveZeros.Move(nums);
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine(); ;
        }
    }
}
