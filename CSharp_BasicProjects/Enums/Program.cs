using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{
    //enum DaysOfWeek
    //{
    //    Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    //}
    public struct Number
    {
        public decimal Amount;
    }

    static void Main(string[] args)
    {
        Number mynumber = new Number();
        mynumber.Amount = 10.01m;

        Console.WriteLine("mynumber: {0}", mynumber.Amount);
        


        //string daysofweekentered;
        //console.writeline("enter the day of the week in full");


        //try
        //{
        //    daysofweekentered = console.readline();
        //    daysofweek dayentered = (daysofweek)enum.parse(typeof(daysofweek), daysofweekentered);
        //    console.writeline("you picked " + dayentered);
        //    console.readline();
        //}
        //catch
        //{
        //    console.writeline("that is not a valid day of the week. try again.");
        //    console.writeline("enter the day of the week in full");
        //    daysofweekentered = console.readline();
        //    daysofweek dayentered = (daysofweek)enum.parse(typeof(daysofweek), daysofweekentered);
        //    console.writeline("you picked " + dayentered);
        //    console.readline();
        //}
        //finally
        //{
        //    console.writeline("days of week are: monday, tuesday, wednesday, thursday, friday, saturday, sunday");
        //    console.writeline("enter the day of the week in full");
        //    daysofweekentered = console.readline();
        //    daysofweek dayentered = (daysofweek)enum.parse(typeof(daysofweek), daysofweekentered);
        //    console.writeline("you picked " + dayentered);
        //    console.readline();
        //}
    }
}