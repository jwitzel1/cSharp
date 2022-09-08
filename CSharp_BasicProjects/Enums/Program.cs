using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{
    enum DaysOfWeek
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
    static void Main(string[] args)
    {
        string DaysOfWeekEntered;
        Console.WriteLine("Enter the day of the week in full");
       

        try
        {
            DaysOfWeekEntered = Console.ReadLine();
            DaysOfWeek dayEntered = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), DaysOfWeekEntered);
            Console.WriteLine("You picked " + dayEntered);
            Console.ReadLine();
        }
        catch
        {
            Console.WriteLine("That is not a valid day of the week. Try again.");
            Console.WriteLine("Enter the day of the week in full");
            DaysOfWeekEntered = Console.ReadLine();
            DaysOfWeek dayEntered = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), DaysOfWeekEntered);
            Console.WriteLine("You picked " + dayEntered);
            Console.ReadLine();
        }
        finally
        {
            Console.WriteLine("Days of week are: Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday");
            Console.WriteLine("Enter the day of the week in full");
            DaysOfWeekEntered = Console.ReadLine();
            DaysOfWeek dayEntered = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), DaysOfWeekEntered);
            Console.WriteLine("You picked " + dayEntered);
            Console.ReadLine();
        }
    }
}