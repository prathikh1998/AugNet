//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LearnChash
//{
//    class Augnet_c4
//    {
//        protected string name = "John";

//        public void Sum(int i, int j)
//        {
//            Console.WriteLine("inherited class");
//        }
//        public void Sum(float i, int j)
//        {
//            Console.WriteLine("inherited 1class");
//        }

//        public void Sum(int i, float j)
//        {
//            Console.WriteLine("inherited 2 class");
//        }

//        public void Sum(float i, float j)
//        {
//            Console.WriteLine("inherited 3 class");
//        }

//    }

//    class Test:Augnet_c4
//    {
//        public void Sum(int i, int j)
//        {
//            base.Sum(i, j);
//            //Console.WriteLine("own class");
//        }
//        //static void Main(string[] args)
//        //{
//        //    Test obj = new Test();
//        //   // Console.WriteLine(obj.name);
//        //    obj.Sum(11, 12);
//        //}
//    }

//    // passing the value by reference
//    class RefTest
//    {
//        public void Sqr(ref int i)
//        {
//            i = i * i;
//        }

        
//        public void getsum(int i, out int sum, out int sub)
//        {
//            sum = i + i;
//            sub = i - i;

//        }
//    }

//    // using ref and out
//    class RefandOut
//    {
        
//        static void Main(string[] args)
//        {
//            int sum;
//            int sub;
//            RefTest obj = new RefTest();
//            int a = 10;
//            Console.WriteLine($"before {a}");
//            obj.Sqr(ref a);
//            Console.WriteLine($"after {a}");
//            obj.getsum(11, out sum, out sub);
//            Console.WriteLine($"sum is {sum} and sub is {sub}");
            
//        }
//    }
//}
