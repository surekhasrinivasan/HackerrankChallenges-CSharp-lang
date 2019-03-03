using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day17_MoreExceptions
{
    public class Calculator
    {
        public int Power(int n, int p)
        {
            if (p < 0 || n < 0)
            {
                throw new Exception("n and p should be non-negative");
            }
            // Base Case 
            if (p <= 0)
            {
                return 1;
            }
            // Recursive Case
            else
            {
                return n * Power(n, p - 1);
            }
        }
    }
}
