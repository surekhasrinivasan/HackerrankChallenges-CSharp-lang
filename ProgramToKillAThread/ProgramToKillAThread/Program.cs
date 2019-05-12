using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgramToKillAThread
{
    // Program to kill a Thread
    class Program
    {
        static void Main(string[] args)
        {
            ThreadingClass th = new ThreadingClass();
            Thread thread1 = new Thread(th.DoStuff);
            thread1.Start();
            Console.WriteLine("Press any key to exit!!!");
            Console.ReadKey();
            th.Stop();
            thread1.Join();
        }
    }

    public class ThreadingClass
    {
        private bool flag = false;
        public void DoStuff()
        {
            while (!flag)
            {
                Console.WriteLine("Thread is still working");
                Thread.Sleep(1000);
            }
        }
        public void Stop()
        {
            flag = true;
        }
    }
}
