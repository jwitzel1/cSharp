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
            List<Employee> tempEmployees = new List<Employee>();
            
            tempEmployees.Add(new Employee { FName = "Joe", LName = "Smith", EmpID = 110 });
            tempEmployees.Add(new Employee { FName="Joe", LName = "Rock", EmpID = 111 });
            tempEmployees.Add(new Employee { FName="Joe", LName = "Wilson", EmpID = 12 });
            tempEmployees.Add(new Employee { FName="Jack", LName = "Smith", EmpID = 113 });
            tempEmployees.Add(new Employee { FName = "Jack", LName = "Wilson", EmpID = 114 });
            tempEmployees.Add(new Employee { FName="Jane", LName = "Foster", EmpID = 15 });
            tempEmployees.Add(new Employee { FName="Julie", LName = "Foster", EmpID = 116 });
            tempEmployees.Add(new Employee { FName="Zoe", LName = "Zack", EmpID = 117 });
            tempEmployees.Add(new Employee { FName="Zero", LName = "Wincombie", EmpID = 18 });
            tempEmployees.Add(new Employee { FName="Prince", LName = "Albert", EmpID = 119 });

            //tempEmployees.ForEach(Console.WriteLine);
            Console.WriteLine("______foreach_______");
            List<Employee> joeEmployees = new List<Employee>();

            foreach (Employee emp in tempEmployees)
            {
                if (emp.FName == "Joe"){
                    joeEmployees.Add(emp);
                    Console.WriteLine(emp.FName + " " + emp.LName);
                }
            }
            
            Console.WriteLine("______lambda_______");
            //lambda
            List<Employee> joeEmp = tempEmployees.Where(x => x.FName == "Joe").ToList();
            foreach (Employee joe in joeEmp)
            {
                    Console.WriteLine(joe.FName + " " + joe.LName);
            }
            //Console.ReadLine();

            Console.WriteLine("______lambda id > 25 _______");
            //lambda
            List<Employee> fiveEmp = tempEmployees.Where(z => z.EmpID > 25).ToList();
            foreach (Employee eid in fiveEmp)
            {
                Console.WriteLine(eid.EmpID + " " + eid.LName + " " + eid.EmpID);
            }
            Console.ReadLine();
            //List<string>? newList = new List<string> {"string1", "string2", "string3" };
            //Employee<string> emp1 = new Employee<string>() { FName = "Sample", LName = "Student", Things = newList };
            //for(int i = 0; i < emp1.Things.Count; i++)
            //{
            //    Console.WriteLine(emp1.Things[i]);
            //}

            //List<int>? newListInt = new List<int> { 4, 5, 6 };
            //Employee<int> emp2 = new Employee<int>() { FName = "Sample", LName = "Student2", Things = newListInt };

            //for (int i = 0; i < emp1.Things.Count; i++)
            //{
            //    Console.WriteLine(emp2.Things[i]);
            //}

            //emp1.SayName();
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


    }
}