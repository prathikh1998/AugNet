using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnChash.Augnet_c12
{
    internal class SemaphoreDemo
    {
        public static Semaphore semaphore = null;
        static void Main(string[] args)
        {
            try
            {
                semaphore = Semaphore.OpenExisting("SemaphoreDemo");
            }
            catch(Exception e)
            {
                semaphore = new Semaphore(2,2,"SemaphoreDemo");
               
            }
            Console.WriteLine("External Thread trying to Acquire");
            semaphore.WaitOne();
            Console.WriteLine("External thread acquired");
            Console.ReadKey();
            semaphore.Release();


        }

        public static void SemaphoreMethod()
        {

        }
    }
}
