using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personInheritance
{
    public class Employee:Person
    {
        public int EmpID { get; set; }

        public  void SayName() //actual method use
        {
            var fullName = FName + " " + LName + ".";
            Console.WriteLine("Name: " + fullName);
        }
    }
    
}
