using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace oneAndTwenty
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the online Casino.  Lets start by telling me your name.");
            // string? playerName = Console.ReadLine();
            string playerName = "Jason";
            Console.WriteLine("How much money did you bring today?");
            //int bank= Convert.ToInt32(Console.ReadLine());
            int bank = 100;
            Console.WriteLine("Hello, {0}, Would you like to play One and Twenty now?", playerName);
            //string? answer= Console.ReadLine();
            string answer = "yes";
            if (answer == "yes" || answer=="yeah" || answer=="ya" || answer == "y") 
            {
                Console.WriteLine("Setting up game now...");
                Player player = new Player(playerName, bank);
   
                Game game = new TwentyOneGame();
                game += player;
               

                player.isActivelyPlaying = true;
                Console.WriteLine("You are IN! ...");
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game-=player;
                Console.WriteLine("Thank you for playing.");
            }
            //chose not to play
            Console.WriteLine("Feel free to look around for now....");
            Console.Read();
        }



    }
}