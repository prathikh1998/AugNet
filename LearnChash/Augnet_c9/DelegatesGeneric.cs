using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LearnChash.Augnet_c9
{

    /* 3 types of built in generic delegates
     * 1.func(system namespace, one or more params upto 16,returns out param,yield keyword)
     * 2.action(one or more params upto 16, returns nothing)
     * 3.predicate(one param, returns bool)
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     */
    internal class DelegatesGeneric
    {
        static void Main(string[] args)
        {
            //Func<int, float, double, double> obj = new Func<int, float, double, double>(AddNumber);
            //double res = obj.Invoke(100, 125.3f, 456.678);
            //Console.WriteLine(res);

            //write in reg
            Func<int, float, double, double> obj = (x, y, z) =>
            {
                return x + y + z;
            };
            double res = obj.Invoke(100, 125.3f, 456.678);
            Console.WriteLine(res);


            //Action<int, float, double> obj2 = new Action<int, float, double>(AddNumber2);
            //obj2.Invoke(100, 125.3f, 456.678);

            Action<int, float, double> obj2 = (x, y, z) =>
            {
                Console.WriteLine(x + y + z);
            };
            obj2.Invoke(100, 125.3f, 456.678);

            //Predicate<string> obj3 = new Predicate<string>(CheckLength);
            //bool result = obj3.Invoke("pRATHIK");
            //Console.WriteLine(result);

            Predicate<string> obj3 = (name) => {
                return name.Length > 5;
            };
            bool result = obj3.Invoke("pRATHIK");
            Console.WriteLine(result);


        }

        private static bool CheckLength(string name)
        {
            if(name.Length > 5)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        private static void AddNumber2(int arg1, float arg2, double arg3)
        {
            Console.WriteLine(arg1+arg2+arg3);
        }

        private static double AddNumber(int arg1, float arg2, double arg3)
        {
            return arg1 + arg2 + arg3;
        }
    }
}
