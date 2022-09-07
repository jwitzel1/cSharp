using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personInheritance
{
    public class Employee : Person, IQuittable
    {
        public int EmpID { get; set; }

        public  void SayName() //actual method use
        {
            var fullName = FName + " " + LName + ".";
            Console.WriteLine("Name: " + fullName);

        }
        public void Quit(string fullName)
        {
            Console.WriteLine("and ... I, " + fullName + " - Quit!");
        }

        //==overload assignment 
        public static bool operator ==(Employee x, Employee y)
        {
            if(x.EmpID == y.EmpID) { return true; } else { return false; }
        }
        public static bool operator !=(Employee x, Employee y)
        {
            if (x.EmpID == y.EmpID) { return false; } else { return true; }
        }

    }
    
}
