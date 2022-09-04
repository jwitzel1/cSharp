using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oneAndTwenty
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();
            List<string> Suits = new List<string>() { "Hearts", "Clubs", "Diamonds", "Spades"};
            List<string> Faces = new List<string>() { "Two", "Three", "Four", "Five", "Six",
                                                        "Seven", "Eight", "Nine", "Ten", "Jack",
                                                        "Queen", "King", "Ace" };

            for (int i = 0; i < Suits.Count; i++)
            {
                for(int j = 0; j < Faces.Count; j++)
                {
                    Card card = new Card();
                    card.Suit = Suits[i];
                    card.Face = Faces[j];
                    Cards.Add(card);    
                }
            }
        }

        public List<Card> Cards { get; set; }   
    }
}
