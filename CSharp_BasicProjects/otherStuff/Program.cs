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


            stringMaker myString = new stringMaker(text0, text1);
            var fullString = "I am jason";
            stringMaker myString2 = new stringMaker(fullString);


        }
    }
}