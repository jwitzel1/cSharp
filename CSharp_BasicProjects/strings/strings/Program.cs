using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringing
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringA = "I am ";
            string stringB = "the ";
            string stringC = "Trinity";
            string combinedString = string.Concat(stringA, stringB, stringC);
           string upperString = combinedString.ToUpper();
            Console.WriteLine(combinedString);
            Console.WriteLine("hmmm.... I guess that would be better like this: \n" + upperString + "\n");

            StringBuilder sbText = new StringBuilder();
            sbText.Append("\n\n \t A paragraph starts with a tab in. \n");
            sbText.Append("Line breaks are common for stylizing. \n");
            sbText.Append("But not necessary, technically.");
            sbText.Append("Each sentence can follow the last...");
            sbText.Append("And we are done. Allowing double line for start of next paragraph. \n\n");

            Console.WriteLine(sbText.ToString());

            Console.ReadLine();

        }
    }
}