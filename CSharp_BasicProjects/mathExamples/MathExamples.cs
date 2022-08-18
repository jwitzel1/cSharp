using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math
{
    class Programm
    {
        static void Main(string[] args)
        {
            //Console.ReadLine();
            Console.WriteLine("starting whole number: ");
            int startNum = Convert.ToInt32(Console.ReadLine());
            int op1 = 50;
            Console.WriteLine("50 x that number is "+Convert.ToString(startNum*op1));
            Console.WriteLine("hit any key to continue...");
            Console.ReadLine();
            
            Console.WriteLine("starting whole number: ");
            int startNum1 = Convert.ToInt32(Console.ReadLine());
            int op2 = 25;
            Console.WriteLine("25 + that number is "+Convert.ToString(startNum1 + op2));
            Console.WriteLine("hit any key to continue...");
            Console.ReadLine();

            Console.WriteLine("starting number: ");
            double startNum2 = Convert.ToDouble (Console.ReadLine());
            double op3 = 12.5;
            Console.WriteLine("That number divided by 12.5 is "+Convert.ToString(startNum2 / op3));
            Console.WriteLine("hit any key to continue...");
            Console.ReadLine();

            Console.WriteLine("Pick a number 1 to 100 ");
            int startNum3 = Convert.ToInt32(Console.ReadLine());
            int op4 = 50;
            Boolean overFifty;
            if(startNum3 > op4) { overFifty=true; } else {  overFifty=false; } 
            Console.WriteLine("Is that number over 50? "+Convert.ToString(overFifty));
            Console.WriteLine("hit any key to continue...");
            Console.ReadLine();

            Console.WriteLine("Pick a whole number ");
            int startNum4 = Convert.ToInt32(Console.ReadLine());
            int op5 = 7;
            int rem = startNum4 % op5;
            Console.WriteLine("If I divide that by 7 I am left with:  "+Convert.ToString(rem));
            Console.WriteLine("hit any key to continue...");
            Console.ReadLine();

        }
    }
}