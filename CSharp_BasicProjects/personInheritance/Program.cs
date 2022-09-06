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
            employee emp1 = new employee();
            emp1.FName = "Sample";
            emp1.LName = "Student";
            emp1.EmpID = 100;
            SayName();

            void SayName()
            {
                var fullName = emp1.FName + " " + emp1.LName + ".";
                Console.WriteLine("Name: " + fullName);
            }
        }

    }
}