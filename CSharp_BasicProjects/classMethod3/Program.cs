using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classNmethod3
{
    class Program
    {
        //main
        static void Main(string[] args)
        {
            doMathStuff3 dm = new doMathStuff3();
             
            dm.doStuff3(34, 22);
            Console.WriteLine("hit enter. watch as we specify parameter by name.");
            Console.ReadLine();
            dm.doStuff3(x: 35, y: 23);
        }
    }
}