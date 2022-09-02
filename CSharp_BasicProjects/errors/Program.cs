using System;

class Program
{
    public static int isErr = 0;
    static void Main(string[] args)
    {

        try
        {
            Console.WriteLine("Imma divide. My numbers by your number.  Your number?");
            int no1=  Convert.ToInt32(Console.ReadLine());
            
        List<int> nos2= new List<int>() { 7, 44, 2, 8 };
            
            foreach (int no2 in nos2) {
                Console.WriteLine("Your number is " + no1 + " and our number is " + no2);
                //int no2 = Convert.ToInt32(Console.ReadLine);
                int no3 = no2 / no1;
                string no3D="";
                if(no3 == 0) {
                    no3D = " greater than zero but less than 1";
                }
                else {
                    no3D = Convert.ToString(no3);
                }
                Console.WriteLine(no2 + " / " + no1 + " equals " + no3D);
            }
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }
        catch (Exception ex)
        {
            string msgD="oops. there was a boo boo: ";
            msgD=msgD + ex.Message;
            Console.WriteLine(msgD);
            Console.ReadLine();
            isErr = 1;
        }
        finally
        {
            if (isErr == 0) {
                Console.WriteLine(isErr + ": Now you know...good job.");
            }
            else
            {
                Console.WriteLine(isErr + ": Errored out.");
            }
        }
    }
}