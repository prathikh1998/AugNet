using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnChash.Augnet_c10
{
    public delegate void ResultCallbackDelegate(int results);
    internal class NumHelper1
    {
        private int _Number;
        private ResultCallbackDelegate _resultCallbackDelegate;

        public NumHelper1(int Number, ResultCallbackDelegate resultCallbackDelegate)
        {
            _Number = Number;
            _resultCallbackDelegate = resultCallbackDelegate;
        }

        public void CalucateSum()
        {
            int result = 0;
            for (int i = 0; i < _Number; i++)
            {
                result += i;
            }
            if(_resultCallbackDelegate != null)
            {
                _resultCallbackDelegate(result);
            }
        }
    }
}
