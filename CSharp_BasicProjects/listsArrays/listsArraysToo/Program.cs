using System;
using System.Collections.Generic;

class loop
{
    static void Main(string[] args)
    {
        string[] strings = { "bear", "bat", "cat", "sloth", "elephant" };
        //input and string array loop
        Console.WriteLine("What is your favorite color?");

        string whatText = Console.ReadLine();

        for (int i = 0; i < strings.Length; i++)
        {
            Console.WriteLine("Look! A " + whatText + " " + strings[i] + "!! \n");

        }

        Console.WriteLine("press enter to continue...");
        Console.ReadLine();
        //infinite, then fix. 
        string[] strings2 = { "one", "one", "one", "one", "five" };

        for (int i = 0; i < strings2.Length; i++) //j++ to i++ to fix. 
        {
            Console.WriteLine("call....response: " + strings2[i] + "\n");

        }

        Console.WriteLine("press enter to continue...");
        Console.ReadLine();


        Console.WriteLine("High Number Ends the game.  Out of 100, can you get greater than 94? \n ");
        //use < and <= 
        int k = 1;
        var randomNum = new Random();
        int thisNum = 0;
        do
        {

            thisNum = randomNum.Next(101);
            Console.WriteLine("num: " + thisNum.ToString() + "\n");
            if (thisNum > 94)
            {
                Console.WriteLine("You did it! On try " + k + ".\n");
            }
            k++;
        }
        while (thisNum < 95);
        Console.ReadLine();
        Console.WriteLine("press enter to continue...");

        Console.WriteLine("Round 2 of High number Ends the game. Can you beat your score of " + k + "?\n Press Enter to Start...\n");
        Console.ReadLine();
        //use < and <= 
        int l = 1;
        var randomNum2 = new Random();
        int thisNum2 = 0;
        do
        {

            thisNum2 = randomNum2.Next(0, 101);
            Console.WriteLine("num2: " + thisNum2.ToString() + "\n");
            if (thisNum2 >= 95) // > 94 and >=95 are the same thing. with ints.
            {
                Console.WriteLine("You did it! On try " + l + ".\n");
                if (k < l)
                {
                    Console.WriteLine("Sorry you did not beat your last score.");
                }
                else if (k == l)
                {
                    Console.WriteLine("It is a tie!!! What are the odds? \n");
                }
                else
                {
                    Console.WriteLine("You did it! You beat your last score!");
                }
            }
            l++;
        }
        while (thisNum2 <= 94); //<=94 is same as <95

        Console.WriteLine("press enter to continue...");
        Console.ReadLine();

        var myList = new List<string>() { "one", "two", "three", "four", "five", "bluebird" };
        Console.WriteLine("Enter a number from one to five, spelled out.");
        string userResponse = Console.ReadLine();
        int found = 0;
        foreach (var listItem in myList)
        {
            if (userResponse == listItem)
            {
                Console.WriteLine(listItem + " and " + userResponse + " is a match!  It is in index value: " + myList.IndexOf(listItem) + ".");
                found = 1;
                break;
            }
        }
        if (found == 0)
        {
            Console.WriteLine("We did not find the value: " + userResponse + " in our list.");
        }
        Console.WriteLine("Press Enter to Continue.");
        Console.ReadLine();




        var myList2 = new List<string>() { "one", "one", "three", "three", "five", "bluebird" };
        var matchList = new List<int>();
        Console.WriteLine("Enter a number from one to five, spelled out.");
        string userResponse2 = Console.ReadLine();
        int found2 = 0; int m = 0;
        foreach (var listItem2 in myList2) //defaults to index order? i wonder...
        {
            // Console.WriteLine("Index: " + myList2.IndexOf(listItem2) + " Value: " + listItem2 + "\n");
            Console.WriteLine("Index: " + m + " Value: " + listItem2 + "\n");
            if (userResponse2 == listItem2)
            {
                //Console.WriteLine(listItem + " and " + userResponse + " is a match!  It is in index value: " + myList.IndexOf(listItem) + ".");
                found2 = 1;
                // matchList.Add(myList2.IndexOf(listItem2));
                //above makes duplicates indexes on duplicate values.
                // break;
                matchList.Add(m);
            }
            m++;
        }
        if (found2 == 0)
        {
            Console.WriteLine("We did not find the value: " + userResponse2 + " in our list.");
        }
        else
        {
            Console.WriteLine("We found a match for " + userResponse2 + " at Index(es):");
            foreach (var matchItem in matchList)
            {
                Console.WriteLine(matchItem + " ");
            }
        }
        Console.WriteLine("Press Enter to Continue.");
        Console.ReadLine();


        Console.WriteLine("Same list - but we will flag duplicates as they appear...Press enter to go...");
        Console.ReadLine();
        var myList3 = new List<string>() { "one", "one", "three", "three", "five", "bluebird" };
        var matchList2 = new List<string>();
        int found3 = 0; int n = 0;
        foreach (var listItem3 in myList3) 
        {
            
            Console.WriteLine("Index: " + n + " Value: " + listItem3 + "\n");
            if (matchList2.Contains(listItem3)) { Console.WriteLine("THAT WAS A DUPLICATE!! \n"); }
            matchList2.Add(listItem3);
            n++;
        }

        Console.WriteLine("Press Enter to Continue.");
        Console.ReadLine();


    }
}
