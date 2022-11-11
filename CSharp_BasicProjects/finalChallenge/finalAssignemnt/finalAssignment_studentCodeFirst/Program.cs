using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Reflection.Metadata;

public class Student
{
    public int sId { get; set; }
    public int StudentID { get; set; }
    public string StudentFirstName { get; set; }
    public string StudentLastName { get; set; }
    public string StudentNotes { get; set; }

    public virtual List<Class> Classes { get; set; }
}

public class Class
{
    public int ClassId { get; set; }
    public string ClassName { get; set; }
    public int ClassGradePct { get; set; }
    public DateTime ClassFinishDate { get; set; }

    public int sId { get; set; }
    public virtual Student Student { get; set; }
}

public class StudentContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Class> Classes{ get; set; }
}



class Program
{
    static void Main(string[] args)
    {
        using (var db = new StudentContext())
        {
           //get student info
            Console.Write("Enter Student First Name ");
            var fName = Console.ReadLine();
            Console.Write("Enter Student Last Name ");
            var lName = Console.ReadLine();
            Console.Write("Enter Student Official School ID ");
            var stIDs = Console.ReadLine();
            int stID = Convert.ToInt32(stIDs);
            Console.WriteLine("Anything Special to Note? Do so below (then press enter, then wait as we build the records...");
            var sNotes = Console.ReadLine();


            var stud = new Student { StudentFirstName = fName, StudentLastName = lName, StudentID = stID, StudentNotes = sNotes };
            db.Students.Add(stud);
            db.SaveChanges();

            // student list coming... 
            var query = from b in db.Students
                        orderby b.StudentFirstName 
                        select b;

            Console.WriteLine("Students to Date:");
            foreach (var st in query)
            {
                Console.WriteLine(st.StudentID + ": " + st.StudentFirstName + " " + st.StudentLastName);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}