using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumInNumOut
{
    class Program
    {
        //main
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number, any number...");
            string numPickS = Console.ReadLine();
            int myNum = Convert.ToInt32(numPickS);

            //Program n1 = new Program();
            doMathStuff n1 = new doMathStuff();

            //dodfg
            Console.WriteLine(myNum + " times itself is: " +  n1.doExp(myNum) + ".");
            Console.WriteLine(myNum + " - 1000 fold - is: " +  n1.doK(myNum) + ".");
            Console.WriteLine(myNum + " flipped on the x axis is: " +  n1.doNeg(myNum) + ".");
            Console.ReadLine();

        }
    }
}