//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LearnChash.Augnet_c6
//{
//    abstract class Abs
//    {
//        abstract public void Dis();
//        public void normal1()
//        {
//            Console.WriteLine("hello there");
//        }

//        public void normal2()
//        {
//            Console.WriteLine("hello there 2");
//        }
//    }

//     class Child : Abs
//    {
//        sealed public override void Dis()
//        {
//            Console.WriteLine("display");
//        }
//    }

//    //anyone can override it again 
//    // so to not let it u need to use sealed

//    //class Child1 : Child
//    //{
//    //    public override void Dis()
//    //    {
//    //        Console.WriteLine("display");
//    //    }
//    //}
//    internal class AbstractClass
//    {
//            static void Main(string[] args)
//            {
//                Child ab = new Child();
//                ab.normal1();
//                ab.normal2();
//                ab.Dis();
//            }
//        }
//}
