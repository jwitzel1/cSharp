using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[] stringArray = {"zero","one","two","three","four"};
    
        Console.WriteLine("Pick an index, any index - in int format, 0 through 4... i am waiting...");
        
        string whatIndex = Console.ReadLine();
        
        Console.WriteLine("the value held in index " + Convert.ToString(whatIndex) + " is ... ");
        
        int indx = Convert.ToInt32(whatIndex);
       
        Console.WriteLine(stringArray[indx]);


        int[] intArray = {10,11,12,13,14 };

        Console.WriteLine("Pick an index, any index - in int format, 0 through 4... i am waiting...");

        int chk = 0;
        do
        {
            string whatIndex2 = Console.ReadLine();
            int indx2= Convert.ToInt32(whatIndex2);  
            if (indx2 == 0 || indx2 == 1 || indx2 == 2 || indx2 == 3 || indx2 == 4)
            {
                Console.WriteLine("the value held in index " + whatIndex2 + " of this array is ... ");

                Console.WriteLine(intArray[indx2]);

                chk = 1;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("between zero and 4, in int format please...again... ");

            }

        } while (chk == 0);
        Console.WriteLine("tap tap tap... ");
        Console.ReadLine();

        List<string> stringList = new List<string>()
            {
                "hup 0", "hup 1", "hup 2", "hup 3", "hup 4"
            };

        Console.WriteLine("Pick an index, any index - in int format, 0 through 4...we are now on a list...");

        string whatIndex3 = Console.ReadLine();

        Console.WriteLine("the value held in index " + Convert.ToString(whatIndex3) + " of this list is ... ");

        int indx3 = Convert.ToInt32(whatIndex3);

        Console.WriteLine(stringList[indx3]);

        Console.ReadLine();

    }
}
