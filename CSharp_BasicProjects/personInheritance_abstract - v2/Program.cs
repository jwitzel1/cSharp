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
            List<string>? newList = new List<string> {"string1", "string2", "string3" };
            Employee<string> emp1 = new Employee<string>() { FName = "Sample", LName = "Student", Things = newList };
            for(int i = 0; i < emp1.Things.Count; i++)
            {
                Console.WriteLine(emp1.Things[i]);
            }

            List<int>? newListInt = new List<int> { 4, 5, 6 };
            Employee<int> emp2 = new Employee<int>() { FName = "Sample", LName = "Student2", Things = newListInt };

            for (int i = 0; i < emp1.Things.Count; i++)
            {
                Console.WriteLine(emp2.Things[i]);
            }

            emp1.SayName();
           // IQuittable emp2 = new Employee() { } ;
         
           // emp2.Quit("Johnny Quitter");

            //==overload assignment 
            //var rand1 = new Random();
            //var rand2 = new Random();
            //Employee emp3 = new Employee() { FName = "Registered", LName = "Student", EmpID = rand1.Next(100, 110) };
            //Employee emp4 = new Employee() { FName = "Registered", LName = "Student", EmpID = rand2.Next(100, 110) };

            //if (emp3 == emp4)
            //{
            //    Console.WriteLine("STOP! Same Emp ID.");
            //}
            //else
            //{
            //    Console.WriteLine("Continue. Different Emp IDs");
            //}
        }

        private class Employee
        {
            private Employee<object> employee;

            public Employee(Employee<object> employee)
            {
                this.employee = employee;
            }

            public string FName { get; set; }
            public string LName { get; set; }
            public List<string> Things { get; internal set; }
        }
    }
}