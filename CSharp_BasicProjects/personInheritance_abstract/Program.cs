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
            Employee emp2 = new Employee() { FName = "Johnny", LName = "Quitter" };
            if (emp2.FName == "Johnny")
            {
                emp2.Quit();
            
            }
                
        }
    }
}