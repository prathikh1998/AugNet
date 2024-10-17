//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LearnChash.Augnet_c6
//{

//    interface IA
//    {
//        void M() { Console.WriteLine("IA:M"); }

//    }

//    interface IB : IA
//    {
//        void M()
//        {
//            Console.WriteLine("IB:M");
//        }
//    }

//    interface IC : IA, IB
//    {
//        void IB.M()
//        {
//            Console.WriteLine("IC:BM");
            
//        }

//        void IA.M()
//        {
//            Console.WriteLine("IC:AM");
//        }
//    }
//    interface IsampleInterface
//    {

//        //for example he adds another fnc but need to implement in it
//        void extraFunction()
//        {

//        }
//        void extraFunction1()
//        {

//        }

//        void extraFunction2() { }

//        void extraFunction3() { }


//        public void interfaceimpl()
//        {
//            Console.WriteLine("interface implementation");
//        }
//        void SampleMethod();

//        void AddMethod();
//        void SubMethod();
//    }
//    class InterfacesDemo : IsampleInterface, IC
//    {

//        static void Main(string[] args)
//        {
//            InterfacesDemo interfacesDemo = new InterfacesDemo();
//            IB isinstance = interfacesDemo;
//            isinstance.M();
//        }
//        public void AddMethod()
//        {
            
//        }

//        public void SampleMethod()
//        {
            
//        }

//        public void SubMethod()
//        {
            
//        }
//    }
//}
