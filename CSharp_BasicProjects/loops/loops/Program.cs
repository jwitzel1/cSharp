using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace counting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number. Watch me count.");
            int myNum = Convert.ToInt32(Console.ReadLine());
            int startNum = 1;
            string counting = Convert.ToString(startNum) + "...";
            while (startNum < myNum)
            {
                startNum++;
                counting = counting + Convert.ToString(startNum) + "...";
            }
            counting = counting + "...ANDDDDD - DONE!";
            Console.WriteLine(counting);
            Console.WriteLine("press enter to continue...");
            Console.ReadLine();

            string firstName;
            string lastName;
            do
            {
                Console.WriteLine("We are looking for friends like us. We will keep looking until we find one!");
                Console.WriteLine("I am Harry Harry.  He is Lou Lou. Are you like us? Who are you?");
                Console.WriteLine("What is your first name?");
                firstName = (Console.ReadLine());
                Console.WriteLine("What is your last name?");
                lastName = (Console.ReadLine());

                Console.WriteLine("Hello " + firstName + " " + lastName);
                string rsp = firstName == lastName ? "You are like us! We found you!! Let us get out of here..." : "You are not like us. Next person please! ";
                Console.WriteLine(rsp);
            } while (firstName != lastName);
            


        }
    }
}