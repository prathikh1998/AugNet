using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnChash.Augnet_c11
{
    internal class MonitorEnter
    {
        private static readonly object lockobj = new object();

        static void Main(string[] args)
        {
            Thread[] t = new Thread[3];
            for (int i = 0; i < t.Length; i++)
            {
                t[i] = new Thread(PrintNumbers)
                {
                    Name = "Child thread " + i.ToString(),
                };
            }
            foreach (Thread t2 in t)
            {
                t2.Start();
            }
        }

        public static void PrintNumbers()
        {
            Console.WriteLine(Thread.CurrentThread.Name + "trying to enter in cs");
            bool IsLockTaken = false;
            try
            {
                Monitor.Enter(lockobj, ref IsLockTaken);
                if (IsLockTaken)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " Entered into cs");
                    for (int i = 0; i <= 5; i++)
                    {
                        Thread.Sleep(1000);
                        Console.WriteLine(i+" ");
                    }
                    Console.WriteLine();
                }
            }
            finally
            {
                if (IsLockTaken)
                {
                    Monitor.Exit(lockobj);
                    Console.WriteLine(Thread.CurrentThread.Name + "exited the cs");
                }
            }
        }
    }
}
