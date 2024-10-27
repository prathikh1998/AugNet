using System;
using System.Diagnostics;
using System.Threading;

namespace LearnChash.Augnet_c13
{
    internal class ThreadPoolDemo
    {
        static void Main(string[] args)
        {
            // Measure and display time for ThreadPool
            Stopwatch stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < 5; i++)
            {
                ThreadPool.SetMinThreads(1,2);
                ThreadPool.SetMaxThreads(1,2);
                ThreadPool.QueueUserWorkItem(MyMethod, i);
                Console.WriteLine($"ThreadPool Thread Count: {ThreadPool.ThreadCount}");
            }
            stopwatch.Stop();
            Console.WriteLine($"Elapsed time for ThreadPool: {stopwatch.ElapsedMilliseconds} ms");

            Console.WriteLine("________________________");

            // Measure and display time for Thread
            stopwatch.Restart();
            for (int i = 0; i < 5; i++)
            {
                Thread thread = new Thread(MyMethod)
                {
                    Name = "Thread: " + i
                };
                thread.Start(i);
            }
            stopwatch.Stop();
            Console.WriteLine($"Elapsed time for Threads: {stopwatch.ElapsedMilliseconds} ms");
        }

        public static void MyMethod(object obj)
        {
            Thread th = Thread.CurrentThread;
            string message = $"Background: {th.IsBackground}, Thread Pool: {th.IsThreadPoolThread}, " +
                             $"Thread ID: {th.ManagedThreadId}, Parameter: {obj}";
            Console.WriteLine(message);
        }
    }
}
