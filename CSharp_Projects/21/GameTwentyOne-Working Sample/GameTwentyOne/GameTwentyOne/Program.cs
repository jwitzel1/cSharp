using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace GameTwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
           string text = "here is some text.";
            File.WriteAllText(@"D:\_jasons_stuff\_fullStack_school\CSharp\cSharp\CSharp_Projects\textDump\log.txt",text);
            File.ReadAllText(@"D:\_jasons_stuff\_fullStack_school\CSharp\cSharp\CSharp_Projects\textDump\log.txt");
            Console.WriteLine("Welcome to the Grand Hotel and Casino. ");
            Console.WriteLine();
            Console.Write("Let's start by telling me your Name:  ");
            string playerName = Console.ReadLine();
            Console.WriteLine();

            bool validAnswer = false;
            int bank = 0;
            while(!validAnswer)
            {
                Console.Write("And how much money did you bring today?  ");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);

                if (!validAnswer) Console.WriteLine("\nPlease enter digits only, no decimals...\n");
                else
                {
                    if (bank <= 0)
                    {
                        Console.WriteLine("\nYou have insufficient funds to play.\n");
                        validAnswer = false;
                        Console.ReadLine();
                        return;
                    }
                }
            }


            Console.WriteLine();
            Console.Write("Hello, {0}.  Would you like to join a game of 21 right now?  ",playerName);
            string answer = Console.ReadLine().ToLower();
            Console.WriteLine();

            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya" || answer == "yea")
            {
                Player player = new Player(playerName,bank);
                Game game = new GameTwentyOne();
                game += player;
                player.isActivelyPlaying = true;
                while(player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();

                    }
                    catch (FraudException e)
                    {
                        Console.WriteLine();
                        Console.WriteLine(e.Message);

                        Console.ReadLine();
                        return;
                    }
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino.  Bye for now.");
            Console.ReadLine();
        }
    }
}
