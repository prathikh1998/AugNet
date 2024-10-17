//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LearnChash.Augnet_c5_indexing
//{
//    class Person1
//    {
//        public string Name { get; set; }
//        public string Dept { get; set; }



//        public Person1(string name, string dept)
//        {
//            Name = name;
//            Dept = dept;

//        }
//    }

//    class Person
//    {
//        Person1[] a;
//        public int length;
//        public bool ErrFlag;

//        public Person(int size)
//        {
//            a = new Person1[size];
//            length = size;
//        }

//        public Person1 this[int index]
//        {
//            get
//            {
//                if (ok(index))
//                {
//                    return a[index];
//                }
//                else
//                {
//                    ErrFlag = false;
//                    return null;
//                }

//            }

//            set
//            {
//                if (ok(index))
//                {
//                    a[index] = value;
//                    ErrFlag = false;
//                }
//                else
//                {
//                    ErrFlag = true;

//                }
//            }
//        }

//        private bool ok(int index)
//        {
//            if (index >= 0 && index < length)
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }
//    }

//    class Augnet_c5_indexing
//    {
//        static void Main(string[] args)
//        {
//            Person p = new Person(5);
//            for (int i = 0; i < p.length; i++)
//            {
//                p[i] = new Person1("name" + i, "dept" + i);

//            }
//            Console.WriteLine(p[1].Name + " " + p[1].Dept);
//        }
//    }
//}
