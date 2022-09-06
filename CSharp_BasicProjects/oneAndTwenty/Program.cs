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

            TwentyOneGame game = new TwentyOneGame();
            game.ListPlayers = new List<string>() { "p1", "p2", "p3" };
            game.ListPlayers();
            Console.ReadLine();

            Deck deck = new Deck();
            deck.Shuffle(3);          

            foreach(Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }



    }
}