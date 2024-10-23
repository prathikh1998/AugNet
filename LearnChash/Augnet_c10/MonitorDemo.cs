using System;
using System.Threading;

namespace LearnChash.Augnet_c10
{
    internal class MonitorDemo
    {
        private static readonly object lockobject = new object();

        static void Main(string[] args)
        {
            Thread[] t = new Thread[3];
            for (int i = 0; i < t.Length; i++)
            {
                t[i] = new Thread(PrimeNumbers)
                {
                    Name = "Child thread " + i.ToString(),
                };
            }
            foreach (Thread t2 in t)
            {
                t2.Start();
            }
        }

        public static void PrimeNumbers()
        {
            Console.WriteLine(Thread.CurrentThread.Name + " trying to enter the cs");
            Monitor.Enter(lockobject);
            try
            {
                Console.WriteLine(Thread.CurrentThread.Name + " entered the cs");
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(100);
                    Console.Write(i + " ");
                }
                Console.WriteLine(); // To ensure the output is on a new line
            }
            finally
            {
                Monitor.Exit(lockobject);
                Console.WriteLine(Thread.CurrentThread.Name + " exited the cs");
            }
        }
    }
}
