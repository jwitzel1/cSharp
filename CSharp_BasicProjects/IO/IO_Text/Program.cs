using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Console.Write("Echo what number:  ");
           // string echoThis = Console.ReadLine();
            //File.WriteAllText(@"D:\_jasons_stuff\_fullStack_school\CSharp\cSharp\CSharp_Projects\textDump\log.txt", echoThis);
           // string echoed=File.ReadAllText(@"D:\_jasons_stuff\_fullStack_school\CSharp\cSharp\CSharp_Projects\textDump\log.txt");
           // Console.WriteLine("echo is:  "+ echoed);

            DateTime dateTime = new DateTime(1995, 5, 23, 8, 32, 45);
           // Console.WriteLine(dateTime);
            DateTime yearOfBirth = new DateTime(1995, 5, 23, 8, 32, 45);
            DateTime yearOfGrad = new DateTime(2020, 6, 1, 16, 34, 22);

         //   TimeSpan = yearOfGrad - yearOfBirth;
          //  Console.WriteLine(TimeSpan + " Days between " + yearOfGrad + " and " + yearOfBirth );
           // Console ReadLine();

              Console.Write("Enter Hours:  ");
            int hrs = Convert.ToInt32(Console.ReadLine());

            DateTime now =  DateTime.Now;
            DateTime dtime=now.AddHours(hrs);
          //  Console.Write(dtime);


         // Console.WriteLine(now);
         

            Console.WriteLine("It is now "+ now + "\n\n In " + hrs + " hours it will be: \n\n" + dtime + ":" + now.Minute);
            Console.ReadLine();
           
            Console.ReadLine();

        
            
        }
    }
}