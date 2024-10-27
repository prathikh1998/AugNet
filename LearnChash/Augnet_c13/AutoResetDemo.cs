using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnChash.Augnet_c13
{
    internal class AutoResetDemo
    {
        static ManualResetEvent autoresetevent = new ManualResetEvent(false);

        static void Main(string[] args)
        {
            //for (int i = 0; i < 5; i++)
            //{
            //    Thread th = new Thread(SomeMethod);
            //    th.Start();

            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.ReadLine();
            //    autoresetevent.Set();
            //}

            Thread th = new Thread(SomeMethod);
            th.Start();
            Thread.Sleep(2000);
            autoresetevent.Set();



        }
        static void SomeMethod()
        {
            Console.WriteLine("starting ....................");
            autoresetevent.WaitOne();
            Console.WriteLine();
            autoresetevent.WaitOne();
            Console.WriteLine("finishing ....................");
           

        }
    }
}
