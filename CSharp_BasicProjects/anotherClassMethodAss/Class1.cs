using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classNmethod5
{
    public class doMathStuff4
    {
        //method in
        public void doStuff4(int x)
        {
            int y = x / 2;
            Console.WriteLine("in: " + x + "out: " + y + ".");
            Console.ReadLine();
        }

        public int doStuff5(int x)
        {
            int y = x * 1000;
            return y;
            
        }

        public int doStuff5(string x)
        {

            int y = -1;
            return y;

        }

    }

    public static class doMathStuff6
    {
        static void giveMeAHunny()
        {
            Console.WriteLine("100");
        }
    }
}
