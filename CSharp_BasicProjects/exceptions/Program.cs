using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findExceptions
{
   
    class Program
    {
        static void Main(string[] args)
        {


            bool good = false;
            int age = 0;
            while (!good)
            {
                
                try
                {
                    Console.WriteLine("NOTE: You must be born to access this site. \n Unborn access to this site is unauthorized.  Rude computer asks, HOW OLD ARE YOU?\n ");
                    age = Convert.ToInt32(Console.ReadLine());
                    if (age <= 0)
                    {
                        
                        Console.WriteLine("** You are unauthorized to be here, unborn! ** ");
                        Console.ReadLine();
                        throw new UnauthorizedAccessException();

                    }
                    int yearBorn = DateTime.Now.Year - age;
                    Console.WriteLine("You were born in the year of our lord {0}.",yearBorn);
                    Console.ReadLine();
                    good=true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("An emergency is going on. I think those were LETTERS, or decimals. We want ONLY numbers.");
                    Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("An emergency is still going on.");
                    Console.ReadLine();
                }
            }
        }
    }
         


}
