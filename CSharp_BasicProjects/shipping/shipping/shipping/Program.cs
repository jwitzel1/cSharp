using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shipping
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("I see you have a package. I will need the weight and each dimension, and will give you a shipping quote in return.");

            Console.WriteLine("How much does the package weigh?");
            int pkgWeight = Convert.ToInt32(Console.ReadLine());
            if (pkgWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.WriteLine("Goodbye");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please provide the package height:");
                double pkgHeight = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please provide the package width:");
                double pkgWidth = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please provide the package length:");
                double pkgLength = Convert.ToDouble(Console.ReadLine());

                if ((pkgHeight + pkgWidth + pkgLength) > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.WriteLine("Goodbye");
                    Console.ReadLine();
                }
                else
                {
                    double pkgDeliveryCost = ((pkgHeight * pkgWidth * pkgLength) * pkgWeight) / 100;
                    Console.WriteLine("The cost to deliver your package is $" + pkgDeliveryCost);
                    Console.WriteLine("Thank you for shipping with Package Express.");
                    Console.ReadLine();
                }
            }


        }
    }
}