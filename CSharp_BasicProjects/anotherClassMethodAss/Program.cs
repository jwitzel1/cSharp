using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classNmethod5
{
    class Program
    {
        //main
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number. We will Havle it.");
            string myNum = Console.ReadLine();
            int x = Convert.ToInt32(myNum); int a;
            doMathStuff4 dm4 = new doMathStuff4();
            dm4.doStuff4(x);
            Console.WriteLine("Press enter to continue.");
            Console.WriteLine("Now can you give me a number?");
            string rslt = Console.ReadLine();
            doMathStuff4 dm5 = new doMathStuff4();
            int i = 0;
            bool result=int.TryParse(rslt, out i);
            if (i != 0)
            {
                int z = Convert.ToInt32(rslt);
                a=(dm5.doStuff5(z));
                Console.WriteLine("result: " + a + ".");
            }
            else
            {
                string z = Console.ReadLine();
                a = (dm5.doStuff5(z));
                Console.WriteLine("result: " + a + ".");
            }
            

        
        }
    }
}