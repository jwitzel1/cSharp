using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classNmethod
{
    class Program
    {
        //main
        static void Main(string[] args)
        {
            Console.WriteLine("Guess how many fingers am I holding up? (1 to 5 please)");
            string numPickS = Console.ReadLine();
            int myNum = Convert.ToInt32(numPickS);

            doPow c = new doPow();
            int pv = 10;
            int pow = c.doPower(myNum, pv);

            Console.WriteLine("My fingers, " + myNum + ", to the power of " + pv + " is: " + pow + ".");
            Console.ReadLine();

            Console.WriteLine("On a scale of 0.1 to 0.9 - how tall do you feel? ");
            string numPickS2 = Console.ReadLine();
            decimal myDec = Convert.ToDecimal(numPickS2);

            doPow d = new doPow();
            decimal mt = 20.5m;
            int dm = d.doPower(mt, myDec);

            Console.WriteLine("If you felt 20 and a half times taller, you would feel this tall: " + dm + ".");
            Console.ReadLine();


            Console.WriteLine("Give me a number bigger than 10 and smaller than 1000 ... ");
            string myN = Console.ReadLine();

            doPow p = new doPow();
            int dp = p.doPower(myN);

            if (dp == 0) { 
                Console.WriteLine("Wow. You got me. I cannot math that.");
            }
            else { Console.WriteLine("If I, an engineer, multiplied that by the value of pi - we would get: " + dp + ".");
            }
            Console.ReadLine();
        }
    }
}