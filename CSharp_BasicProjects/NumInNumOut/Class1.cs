using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumInNumOut
{
    public class doMathStuff
    {
        //methods
        public int doExp(int x)
        {
            int expDo = x * x;
            return expDo;
        }

        public int doK(int x)
        {
            int kDo = x * 1000;
            return kDo;
        }

        public int doNeg(int x)
        {
            int negDo = 0 - x;
            return negDo;
        }
    }
}