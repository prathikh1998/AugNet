//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LearnChash
//{// use private ctr when u have static members
//    class Augnet_c5
//    {
//        private static string region;
//        private string locationName;
//        private string dept;
//        public Augnet_c5() { }
//        public Augnet_c5(string name) => (Name, Dept) = (name, dept);
//        public string Name { get => locationName; set => locationName = value; }
//        public string Dept
//        {
//            get => dept; set => dept = value;
//        }
//        public static string Region { get => region; set => region = value; }
//    }

//    public static class Test1
//    {
//        public static double PI = 3.14;
//        public static int GetSquares(int i)
//        {
//            return i * i;
//        }
//    }

//    class ConstructorDemo
//    {
//        static void Main(string[] args)
//        {
//            Augnet_c5 c5 = new Augnet_c5();
//            c5.Dept = "HR";
//            Singleton obj1 = Singleton.GetSingletonInstance();
//            obj1.SomeMethod("first instance");
//            Singleton obj2 = Singleton.GetSingletonInstance();
//            obj2.SomeMethod("second instance");


//        }
//    }

//    sealed class Singleton
//    {
//        private static int counter = 0;
//        private static Singleton instance = null;
//        private static readonly object InstanceLock = new object();

//        public static Singleton GetSingletonInstance()
//        {
//            lock (InstanceLock)
//            {
//                if (instance == null)
//                {
//                    instance = new Singleton();
//                }
//                return instance;
//            }
//        }
//        private Singleton()
//        {
//            counter++;
//            Console.WriteLine($"singleton ctr invoked {counter}");
//        }

//        public void SomeMethod(string message)
//        {
//            Console.WriteLine(message);
//        }

//        ~Singleton()
//        {
//            Console.WriteLine("calling desctructor");
//        }
//    }


//    //Using the virtual keyword for
//    //properties allows you to define
//    //behavior in a base class that can be
//    //customized in derived classes,
//    //enhancing the flexibility and
//    //scalability of your code.
//    public class Animal
//    {
//        public virtual string Sound { get; } = "Some sound";
//    }


//    public class Dog : Animal
//    {
//        public override string Sound { get; } = "Bark";
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Animal myAnimal = new Animal();
//            Animal myDog = new Dog();

//            Console.WriteLine(myAnimal.Sound); // Output: Some sound
//            Console.WriteLine(myDog.Sound);     // Output: Bark
//        }
//    }








//    class Dimesions
//    {
//        new public double Area(int i, int j)
//        {
//            return i * j;
//        }

//    }

//    class Test2 : Dimesions
//    {
//        public virtual double Area(int i, int j)
//        {
//            return i - j;
//        }
//    }
//    class VirtualDemo : Test2
//    {
//        public override double Area(int i, int j)
//        {
//            return i + j;
//        }

//        static void Main(string[] args)
//        {
//            VirtualDemo demo = new VirtualDemo();
//            Console.WriteLine(demo.Area(1, 2));


//        }
//    }


//}
