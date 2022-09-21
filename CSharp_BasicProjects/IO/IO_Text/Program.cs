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
            Console.Write("Echo what number:  ");
            string echoThis = Console.ReadLine();
            File.WriteAllText(@"D:\_jasons_stuff\_fullStack_school\CSharp\cSharp\CSharp_Projects\textDump\log.txt", echoThis);
            string echoed=File.ReadAllText(@"D:\_jasons_stuff\_fullStack_school\CSharp\cSharp\CSharp_Projects\textDump\log.txt");
            Console.WriteLine("echo is:  "+ echoed);
        }
    }
}