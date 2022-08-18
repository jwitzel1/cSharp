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
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1 Please Approach. Person 2 LEAVE or cover eyes.");

            Console.WriteLine("Person 1 please enter Hourly Rate of your pay:");
            decimal p1Hourly = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Person 1 please enter averge weekly hours worked:");
            decimal p1WeeklyHours = Convert.ToDecimal(Console.ReadLine());
            decimal p1AnnualSalary = p1Hourly * p1WeeklyHours * 52;

            Console.WriteLine("Person 2 Please Approach. Person 1 LEAVE or cover eyes.");

            Console.WriteLine("Person 2 please enter Hourly Rate of your pay:");
            decimal p2Hourly = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Person 2 please enter averge weekly hours worked:");
            decimal p2WeeklyHours = Convert.ToDecimal(Console.ReadLine());
            decimal p2AnnualSalary = p2Hourly * p2WeeklyHours * 52;

            Console.WriteLine("RESULTS: ");
            Console.WriteLine("Annual Salary of Person 1: ");
            Console.WriteLine("$" + p1AnnualSalary);
            Console.WriteLine("Annual Salary of Person 2: ");
            Console.WriteLine("$" + p2AnnualSalary);

            Boolean ver;
            if (p1AnnualSalary > p2AnnualSalary) { ver = true; } else { ver = false; }
            Console.WriteLine("Person 1 makes more money than Person 2: ");
            Console.WriteLine(ver);

            Console.ReadLine();
        }
    }
}