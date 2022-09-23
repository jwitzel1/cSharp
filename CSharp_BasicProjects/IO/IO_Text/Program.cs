using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherStuff
{
    public class stringMaker
    {
        public stringMaker(string a) : this(a, ".")
        {

        }
        public stringMaker(string a, string b)
        {
            string first = a.ToUpper();
            string second = b;
            string last = ".";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            const string userName = "Dude";
            string text0 = "i";
            string text1 = " am jason";
            

            stringMaker myString = new stringMaker(text0,text1);
            var  fullString = "I am jason";
            stringMaker myString2 = new stringMaker(fullString);


            //DateTime dateTime = new DateTime(1995, 5, 23, 8, 32, 45);

            //DateTime yearOfBirth = new DateTime(1995, 5, 23, 8, 32, 45);
            //DateTime yearOfGrad = new DateTime(2020, 6, 1, 16, 34, 22);

            //Console.Write("Enter Hours:  ");
            //int hrs = Convert.ToInt32(Console.ReadLine());

            //DateTime now =  DateTime.Now;
            //DateTime dtime=now.AddHours(hrs);

            //Console.WriteLine("It is now "+ now + "\n\n In " + hrs + " hours it will be: \n\n" + dtime + ":" + now.Minute);
            //Console.ReadLine();

        }
    }
}