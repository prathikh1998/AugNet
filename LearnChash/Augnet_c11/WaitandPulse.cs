using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnChash.Augnet_c11
{
    internal class WaitandPulse
    {
        const int nmberLimit = 20;
        private static readonly object lockobj = new object();

        public static void PrintEvenNumbers()
        {
            try
            {
                Monitor.Enter(lockobj);
              
                    for (int i = 0; i <= nmberLimit; i+=2)
                    {
                       
                        Console.Write(i + " ");
                        Console.WriteLine();
                        Monitor.Pulse(lockobj);

                        bool isLast = false;
                    if(i == nmberLimit)
                    {
                        isLast = true;
                    }
                    if (!isLast)
                    {
                        Monitor.Wait(lockobj);
                    }
                }
                    
                
            }
            finally
            {
                Monitor.Exit(lockobj);
            }
        }

        public static void PrintOddNumbers()
        {
            try
            {
                Monitor.Enter(lockobj);

                for (int i = 1; i <= nmberLimit; i += 2)
                {

                    Console.Write(i + " ");
                    Console.WriteLine();
                    Monitor.Pulse(lockobj);

                    bool isLast = false;
                    if (i == nmberLimit-1)
                    {
                        isLast = true;
                    }
                    if (!isLast)
                    {
                        Monitor.Wait(lockobj);
                    }
                }


            }
            finally
            {
                Monitor.Exit(lockobj);
            }
        }

        static void Main(string[] args)
        {
            Thread evenThread = new Thread(PrintEvenNumbers);
            Thread oddThread = new Thread(PrintOddNumbers);

            evenThread.Start();
            Thread.Sleep(100);
            oddThread.Start();

            evenThread.Join();
            oddThread.Join();

        }
    }
}


