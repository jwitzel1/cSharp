using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classNmethod
{
    public class doPow
    {
        //method in
        public int doPower(int x, int p=4)
        {
            int powDo = (int)Math.Pow(x, p);
            return powDo;
        }
        //method dec
        public int doPower(decimal x, decimal p = 4)
        {
            decimal powDo = x * p;
            int v = Convert.ToInt32(powDo);
            return v;
        }

        //method string
        public int doPower(string x, int pi = 3)
        {
            int i = 0;
            bool result = int.TryParse(x, out i);
            if (i != 0)
            {
                int y = pi * i;
                return y;
            }
            else
            {
                return 0;
            }
        }

    }
}
