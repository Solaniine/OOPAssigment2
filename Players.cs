using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment2
{
    internal class Player
    {
        public int PlayerId { get { return playerid; } set { playerid = value; } }
        public string PlayerName { get { return playername; } set { playername = value; } }
        public int Playerscore { get { return playerscore; } set { playerscore = value; } }

        private int playerid;
        private string playername;
        int playerscore;
       

        public void Player_scoresupdate(int score)
        {

            Playerscore += score;

        }

        public Player(int id, string name, int score)
        {
            playerid = id;
            playername = name;
            playerscore = score;
        }




    }

}

    