using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assigment2
{
    class theProgram
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Rules \r\n Players in turn roll all five dice and score for three-of-a-kind or better. \r\n If a player only has two-of-a-kind, \r\n they may re-throw the remaining dice in an attempt to improve the matching dice values. \r\n If no matching numbers are rolled, a player scores 0. \r\n");

            Players players = new Players();
            Console.WriteLine("input the number of players");
            players.playeramount();

            int playerid = i + 1;
            int numberofplayers = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberofplayers; i++)
            {
                
                Console.Write("Please enter the name of player " + playerid + ": ");
                string playerName = Console.ReadLine();

                players.Add(new players(playerid, playerName, 0));;
            }
            foreach (var player in playeramount)
            {
                Console.WriteLine(player.playernames + " " + player.PlayerScore);
            }



        }
    }
}

