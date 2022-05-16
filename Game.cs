using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment2
{
    internal class Game
    {
        public static void check_dice(Players player, List<int> diceValues)
        {
            int score = 0;
            var grouped = diceValues.GroupBy(x => x);
            score += grouped.Count(x => x.Count() == 3) * 3;
            score += grouped.Count(x => x.Count() == 4) * 6;
            score += grouped.Count(x => x.Count() == 5) * 12;
            player.Player_scores(score);

        }
    }
}
