using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnChash.Augnet_c11
{
    internal class MutexDemo
    {
        private static Mutex mutex = new Mutex();
        static void Main(string[] args)
        {
            //using(Mutex mutex = new Mutex(false,"MutexDemo"))
            //{
            //    Console.WriteLine("Application is running");
            //    if (!mutex.WaitOne(5000, false))
            //    {
            //        Console.WriteLine("an instance of the application is already running");
            //        Console.ReadKey();
            //    }
            //    Console.WriteLine("application is already running");
            //    Console.ReadKey();
            //    Console.ReadLine();
            //}

            Thread[] t = new Thread[3];
            for (int i = 0; i < t.Length; i++)
            {
                t[i] = new Thread(MutexMethod)
                {
                    Name = "Child thread " + i.ToString(),
                };
            }
            foreach (Thread t2 in t)
            {
                t2.Start();
            }


        }

        public static void MutexMethod()
        {
            Console.WriteLine(Thread.CurrentThread.Name + " Wants to enter the cs");
            
                if (mutex.WaitOne(1000))
                {
                    try
                    {
                        Console.WriteLine("success " + Thread.CurrentThread.Name);
                        Thread.Sleep(2000);
                        Console.WriteLine("exit " + Thread.CurrentThread.Name);
                    }
                    finally
                    {
                        mutex.ReleaseMutex();
                    }

                }
                 else
                {
                Console.WriteLine(Thread.CurrentThread.Name + " will not azquire thess mutex");

            }    

        }
        ~MutexDemo()
        {
            mutex.Dispose();
        }
    }
}
