using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnChash.Augnet_c11
{
    internal class OpenExisting
    {
        static Mutex mutex;
        static void Main(string[] args)
        {
            if (!IsSingleInstance())
            {

                Console.WriteLine("more than one instance");
                Thread.Sleep(5000);
            }
            else
            {
                Console.WriteLine("one instance");
               
                Thread.Sleep(5000);
            }
        }

        static bool IsSingleInstance()
        {
            try
            {
                Mutex.OpenExisting("MyMutex");
            }
            catch
            {
                mutex = new Mutex(true, "MyMutex");
                return true;
            }
            return false;
        }
    }
}
