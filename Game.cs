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
            //Score 3 of a kinds
            score += grouped.Count(x => x.Count() == 3) * 3;
            //Score 4 of a kinds
            score += grouped.Count(x => x.Count() == 4) * 6;
            //Score 5 of a kinds
            score += grouped.Count(x => x.Count() == 5) * 12;

            // change the player's score accordingly
            player.Player_scores(score);

        }
    }
}
