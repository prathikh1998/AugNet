using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LearnChash.Augnet_c10
{
    internal class PassDataInTypeSafeManner
    {
       
        static void Main(string[] args)
        {

            ResultCallbackDelegate resultCallback = new ResultCallbackDelegate(ResultCallbackMethod);
            int Number = 5;

            NumHelper1 obj = new NumHelper1(Number, resultCallback);
            Thread th = new Thread(new ThreadStart(obj.CalucateSum));
            th.Start();

            //    ParameterizedThreadStart ph = new ParameterizedThreadStart(new PassDataInTypeSafeManner().DisplayMemebers);
            //    Thread th = new Thread(ph);
            //    th.Start("11");
            //}

            //public void DisplayMemebers(object Max)
            //{
            //    int i = Convert.ToInt32(Max);
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.WriteLine(j);
            //    }
            //}

            //int Max = 5;
            //NumHelper nh = new NumHelper(Max);
            //Thread th = new Thread(new ThreadStart(nh.DisplayMemebers));
            //th.Start();
            //th.Join();
        }
        public static void ResultCallbackMethod(int results)
        {
            Console.WriteLine("result is " + results);
        }
    }
}
