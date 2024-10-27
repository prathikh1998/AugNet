using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnChash.Augnet_c12
{
    
    internal class SemaphoreSlimDemo
    {
        public static SemaphoreSlim semaphore = new SemaphoreSlim(initialCount: 3);
       
            static void Main(string[] args)
            {
            for (int i = 0; i < 5; i++)
            {
                int count = i;
                Thread obj = new Thread(() => SlimFn("Thread" + i, count * 1000));
                obj.Start();

            }
            Console.ReadKey();
            }

        static void SlimFn(string name, int seconds)
        {
            Console.WriteLine($"{name} wants to access the cs");
            semaphore.Wait();
            Console.WriteLine($"{name} granted access to cs");
            Thread.Sleep( seconds );
            Console.WriteLine($"{name} exited the cs");
            semaphore.Release();
        }
    }
}
