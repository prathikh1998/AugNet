using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnChash
{
    class Members
    {
        //member - private
        private string memberName;
        private string jobTitle;
        private int salary = 20000;

        //member - public
        public int age;

        //memer - propertkly starts with capital letter
        public string JobTitle {
            get {
                return jobTitle;

            }
            set {
                jobTitle = value;
            }
        }

        //member - method can be called from other classes

        public void introduce(bool isFrnd)
        {
            if (isFrnd)
            {
                sharingPrivate();
            }
            else
            {
                Console.WriteLine("hi my name is {0} and job is {1}", memberName, jobTitle);
            }

        }

        private void sharingPrivate()
        {
            Console.WriteLine("MY salary si {0}", salary);
        }

        //member - constructor
        public Members()
        {
            age = 30;
            memberName = "lucy";
            jobTitle = "developer";
            Console.WriteLine("object created");
        }

        //member - destructor

        ~Members() {
            Console.WriteLine("Called");
            Debug.Write("destruction");
        }


        
    }

}

