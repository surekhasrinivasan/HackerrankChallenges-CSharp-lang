using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintAlphabetTriangle
{
    // Program to print Alphabet Triangle
    class Program
    {
        static void Main(string[] args)
        {
            char ch = 'A';
            int i, j, k, m;

            for(i = 1; i <=6; i++)
            {
                for(j=6;j>=i;j--)
                    Console.Write(" ");
                for(k=1;k<=i;k++)
                    Console.Write(ch++);
                ch--;
                for(m=1;m<i;m++)
                    Console.Write(--ch);
                Console.Write("\n");
                ch = 'A';
            }
        }
    }
}
