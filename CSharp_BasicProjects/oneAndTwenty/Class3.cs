using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oneAndTwenty
{
    public class Player
    {
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }

        public static Game operator+ (Game, Player player)
        {
            Game.Players.Add(player);
            return Game;
        }

        public static Game operator- (Game, Player player)
        {
            Game.Players.Remove(player);
            return Game;
        }

    }
}
