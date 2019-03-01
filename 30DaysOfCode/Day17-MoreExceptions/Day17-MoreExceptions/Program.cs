using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day17_MoreExceptions
{
    /* Write a Calculator class with a single method: int power(int,int). 
     * The power method takes two integers, n and p, as parameters and returns the integer result of n^p. 
     * If either n or p is negative, then the method must throw an exception with the message: n and p should be non-negative. 
     */
    class Program
    {
        static void Main(string[] args)
        {
            Calculator myCalculator = new Calculator();
            Console.WriteLine("Enter the number of Testcases: ");
            int T = Int32.Parse(Console.ReadLine());

            while (T-- > 0)
            {
                Console.WriteLine("Enter space-separated integers denoting n and p: ");
                string[] num = Console.ReadLine().Split();
                int n = int.Parse(num[0]);
                int p = int.Parse(num[1]);
                try
                {
                    int ans = myCalculator.Power(n, p);
                    Console.WriteLine(ans);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
            }
        }
    }
}
