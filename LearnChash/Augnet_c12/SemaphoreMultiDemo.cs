using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnChash.Augnet_c12
{
    internal class SemaphoreMultiDemo
    {
        public static Semaphore semaphore = new Semaphore(2,3);

        static void Main(string[] args)
        {
            Thread[] t = new Thread[4];
            for (int i = 0; i < t.Length; i++)
            {
                t[i] = new Thread(DoSomeTask)
                {
                    Name = "Child thread " + i.ToString(),
                };
            }
            foreach (Thread t2 in t)
            {
                t2.Start();
            }
        }
        static void DoSomeTask()
        {
            Console.WriteLine(Thread.CurrentThread.Name + " wants to enter into cs");
            try
            {
                semaphore.WaitOne();
                Console.WriteLine(Thread.CurrentThread.Name + " is processing into cs");
                Console.WriteLine(Thread.CurrentThread.Name + " exited the cs");

                Thread.Sleep(5000);
                Console.ReadKey();
            }
           finally
            {
                semaphore.Release();
            }


        }
    }
}
