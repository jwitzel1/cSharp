using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classNmethod2
{
    class Program
    {
        //main
        static void Main(string[] args)
        {
            string zzz = ""; int i = 0; int myNum1;
            do
            {
                
                Console.WriteLine("Ima ask for 2 positive numbers.  First number please: ");

                doMathStuff d = new doMathStuff();

                string numPick1 = Console.ReadLine();
               

                bool result1 = int.TryParse(numPick1, out i);
                if (i != 0)
                {
                    myNum1 = Convert.ToInt32(numPick1);
                }
                else
                {
                    myNum1 = 11;
                    Console.WriteLine("All right - we will just go ahead and round that up to " + myNum1); ;
                }



                Console.WriteLine("Now the second number. Or just hit enter - the step is optional");
                string myNum2 = Console.ReadLine();
                int y; int rslt; string strRslt;
                bool result2 = int.TryParse(myNum2, out i);
                if (i != 0)
                {
                    y = Convert.ToInt32(myNum2);
                    rslt = d.doStuff(myNum1, y);
                    strRslt = "We took your two numbers (" + myNum1 + " and " + myNum2 + ") and ";
                }
                else
                {
                    rslt = d.doStuff(myNum1);
                    strRslt = "We took your numbers (" + myNum1 + ") and ";
                }

                strRslt += " did math stuff and got result of " + rslt + ". \nCan you guess what math stuff we did? Try more numbers if you need to - it is the same stuff we do each time...";
                Console.WriteLine(strRslt);
                Console.WriteLine("type 'quit' to quit. Or hit enter to keep guessing.");
                
                zzz=Console.ReadLine();

            } while (zzz != "quit");
        }
    }
}