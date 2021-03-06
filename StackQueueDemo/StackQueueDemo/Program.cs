﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueDemo
{
    //Program to demo Queue and Stacks
    class Program
    {
        static void Main(string[] args)
        {
            //Queue q = new Queue();

            //q.Enqueue('A');
            //q.Enqueue('M');
            //q.Enqueue('G');
            //q.Enqueue('W');

            //Console.WriteLine("Current queue: ");
            //foreach (char c in q) Console.Write(c +" ");

            //Console.WriteLine();
            //q.Enqueue('V');
            //q.Enqueue('H');
            //Console.WriteLine("Current queue: ");
            //foreach (char c in q) Console.Write(c + " ");

            //Console.WriteLine();
            //Console.WriteLine("Removing some values ");
            //char ch = (char)q.Dequeue();
            //Console.WriteLine("The removed value: {0}", ch);
            //ch = (char)q.Dequeue();
            //Console.WriteLine("The removed value: {0}", ch);

            //Console.Read();

            Stack st = new Stack();

            st.Push('A');
            st.Push('M');
            st.Push('G');
            st.Push('W');

            Console.WriteLine("Current Stack: ");
            foreach(char c in st)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();

            st.Push('V');
            st.Push('H');
            Console.WriteLine("The next poppable value in stack: {0}", st.Peek());
            Console.WriteLine("Current stack: ");

            foreach(char c in st)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Removing values ");
            st.Pop();
            st.Pop();
            st.Pop();

            Console.WriteLine("Current stack: ");
            foreach(char c in st)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
        }
    }
}
