//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LearnChash.Augnet_c8
//{
//    internal class LambdaDemo
//    {
//        delegate int Incr(int i);
//        delegate bool IsEvent(int v);
//        delegate bool IsRange(int low, int high,int value);
//        delegate int Intop(int end);
//        static void Main(string[] args)
//        {
//            //(param list)=> expr

//            Incr incr = count => count + 2;
//            int x = -10;
//            while(x<= 0)
//            {
//                Console.WriteLine(x);
//                x = incr(x);

//            }

//            //iseven lambda

//            IsEvent even = n => n % 2 == 0;
//            for (int i = 0; i < 10; i++)
//            {
//                if (even(i))
//                {
//                    Console.WriteLine(i);
//                }
//            }

//            //isrange lambda

//            IsRange rangeno = (low, high, value) => (value >= low && value <= high);
//            for (int i = 0; i < 10; i++)
//            {
//                if (rangeno(2, 8, i))
//                {
//                    Console.WriteLine("in Range " + i);
//                }
//                else
//                {
//                    Console.WriteLine("Not in range "+i);
//                }
//            }

//            //factorial
//            Intop fact = n =>
//            {
//                int r = 1;
//                if (n == 0 || n == 1)
//                {
//                    return 1;
//                }
//                else
//                {
//                    for (int i = 2; i <= n; i++)
//                    {
//                        r = r * i;
//                    }
//                    return r;
//                }
//            };
//            Console.WriteLine(fact(10));

//        }
//    }
//}
