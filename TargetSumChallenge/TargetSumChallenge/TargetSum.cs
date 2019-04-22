using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetSumChallenge
{
    public static class TargetSum
    {
        public static bool TwoIntegersSumToTarget(int[] arr, int target)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                for(int k = 0; k < arr.Length; k++)
                {
                    if(i != k)
                    {
                        int sum = arr[i] + arr[k];
                        if (sum == target)
                            return true;
                    }
                }
            }
            return false;
        }
    }
}
