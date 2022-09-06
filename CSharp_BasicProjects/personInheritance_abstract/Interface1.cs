using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personInheritance
{
    public interface IQuittable
    {
        public static void Quit()
        {
            Console.WriteLine("You just quit. Goodbye.");
        }
    }
}
