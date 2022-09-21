using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTwentyOne
{
    public class Deck
    {

        public List<Card> Cards { get; set; }

        public Deck()
        {
            Cards = new List<Card>();

            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 13; j++)
                {
                    Card card = new Card();
                    card.Suit = (Suit)i;
                    card.Face = (Face)j;
                    Cards.Add(card);
                }
                           
            }
        }

        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random R = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = R.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);

                }
                Cards = TempList;
            }

        }


        public void Shuffle(out int timesShuffled, out string test, int times = 1)
        {
            timesShuffled = 0;
            test = "Second out parameter";
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random R = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = R.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);

                }
                Cards = TempList;
                timesShuffled++;
            }
        }
    }
}
