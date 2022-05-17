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
            int numberofplayers;

            Console.WriteLine("Rules \r\n Players in turn roll all five dice and score for three-of-a-kind or better. \r\n If a player only has two-of-a-kind, \r\n they may re-throw the remaining dice in an attempt to improve the matching dice values. \r\n If no matching numbers are rolled, a player scores 0. \r\n");

            Players players = new Players();
            Console.WriteLine("input the number of players");
            Players.playeramount() ;
            
            

            RollingDie die = new RollingDie();
            Console.WriteLine(die.Returndiceroll());

        }
    }
}

