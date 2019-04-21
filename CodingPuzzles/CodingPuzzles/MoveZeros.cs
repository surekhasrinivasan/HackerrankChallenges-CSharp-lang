using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    public static class MoveZeros
    {
        public static void Move(params int[] x)
        {
            for(int i = 0; i < x.Length; i++)
            {
                if(x[i] == 0)
                {
                    MoveZeroToEnd(x, i);
                }
            }
        }

        private static void MoveZeroToEnd(int[] x, int index)
        {
            for(int i = index; i < x.Length-1; i++)
            {
                int temp = x[i];
                x[i] = x[i + 1];
                x[i + 1] = temp;
            }
        }
    }
}
