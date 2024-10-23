using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnChash.Augnet_c10
{
    internal class NumHelper
    {
        int _Number;

        public NumHelper(int Number)
        {
            _Number = Number;
        }

        public void DisplayMemebers()
        {
            int count = 0;
            
            for (int j = 0; j < _Number; j++)
            {
                Console.WriteLine(j);
                count += 1;
            }

           
        }
    }


}
