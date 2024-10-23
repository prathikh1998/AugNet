using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnChash.Augnet_c9
{
    internal class ThreadDemo
    {
        static void Main(string[] args)
        {
            Thread t = Thread.CurrentThread;
            t.Name = "Main thread";
            Console.WriteLine(t.Name);
            //Method1();
            //Method2();
            //Method3();
            Thread t1 = new Thread(Method1)
            {
                Name = "Thread 1"
            };

            Thread t2 = new Thread(Method2)
            {
                Name = "Thread 2"
            };

            Thread t3 = new Thread(Method3)
            {
                Name = "Thread 3"
            };

            t1.Start();
            t1.Join();
            t2.Start();
            t2.Join();
            t3.Start();
            t3.Join();

            Console.WriteLine("MAin Ended");
        }

        static void Method1()
        {
            Console.WriteLine("method1 started");
           
            for (int i = 0; i < 5; i++)
           
            {
           
                Console.WriteLine("Method1 : "+i);
           
            }
            Console.WriteLine("_____________________________");
        }

        static void Method2()
        {
            Console.WriteLine("method2 started");

            for (int i = 0; i < 5; i++)

            {

                Console.WriteLine("Method2 : " + i);
                Thread.Sleep(1000);

            }
            Console.WriteLine("_____________________________");

        }

        static void Method3()
        {
            Console.WriteLine("method3 started");

            for (int i = 0; i < 5; i++)

            {

                Console.WriteLine("Method3 : " + i);

            }
            Console.WriteLine("_____________________________");

        }




    }

}
