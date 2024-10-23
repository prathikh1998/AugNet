using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnChash.Augnet_c10
{
    internal class ThreadSync
    {
        static object lockobj = new object();
        static void Main(string[] args)
        {
            Thread thread = new Thread(SomeMethod)
            {
                Name = "thread1"
            };
            Thread thread2 = new Thread(SomeMethod)
            {
                Name = "thread2"
            }; 
            Thread thread3 = new Thread(SomeMethod)
            {
                Name = "thread3"
            };
            thread.Start("thread1");
            thread2.Start("thread2");
            thread3.Start("thread3");


        }

        public static void SomeMethod(object name)
        {
            lock (lockobj) {
                Console.WriteLine("This is a shared method " + name);
                Thread.Sleep(1000);
                Console.WriteLine("SomeMethod Ends " + name);
            } }


    }
}
