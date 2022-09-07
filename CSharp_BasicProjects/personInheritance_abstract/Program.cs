using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace personInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee() { FName = "Sample", LName = "Student" };
            emp1.SayName();
            IQuittable emp2 = new Employee() { } ;
         
            emp2.Quit("Johnny Quitter");

            //==overload assignment 
            var rand1 = new Random();
            var rand2 = new Random();
            Employee emp3 = new Employee() { FName = "Registered", LName = "Student", EmpID = rand1.Next(100, 110) };
            Employee emp4 = new Employee() { FName = "Registered", LName = "Student", EmpID = rand2.Next(100, 110) };

            if (emp3 == emp4)
            {
                Console.WriteLine("STOP! Same Emp ID.");
            }
            else
            {
                Console.WriteLine("Continue. Different Emp IDs");
            }
        }
    }
}