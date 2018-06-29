using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Algorithm1
{
    class Solution
    {
        static void Main(string[] args)
        {
            //https://www.hackerrank.com/challenges/queue-using-two-stacks/problem

            Stack<int> stack1 = new Stack<int>();
            Stack<int> stack2 = new Stack<int>();

            // Number of queries
            int q = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < q; i++)
            {
                string[] line_temp = Console.ReadLine().Split(' ');
                int[] line = Array.ConvertAll(line_temp, Int32.Parse);

                if (stack2.Count == 0)
                {
                    while (stack1.Count != 0)
                        stack2.Push(stack1.Pop());
                }

                // Enqueue
                if (line.Length == 2)
                {
                    if (stack2.Count == 0)
                        stack2.Push(line[1]);
                    else
                        stack1.Push(line[1]);
                }
                else
                {
                    // Dequeue
                    if (line[0] == 2)
                        stack2.Pop();
                    // Print
                    else if (line[0] == 3)
                        Console.WriteLine(stack2.Peek());
                }
            }
        }
    }
}

