using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salary
{
    class Program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BOO-YA");

            Console.WriteLine("Car Insurance Qualifiers.");

            Console.WriteLine("How Old Are you?:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You have had a DUI charge? (reply true/false) ");
            bool DUI  = Convert.ToBoolean(Console.ReadLine());
           
            Console.WriteLine("How many speading tickets have you had? ");
            int tickets = Convert.ToInt32 (Console.ReadLine());

            Boolean allowed;
            if (tickets > 3 || DUI == true || age <= 15) { allowed = false; } else { allowed = true; }  
                Console.WriteLine("Eligable for car insurance: ");
                Console.WriteLine(allowed);

            Console.ReadLine();
        }
    }
}