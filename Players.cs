using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment2
{
    internal class Players
    {
        private int playerID;
        private string playername = "";
        private int playerscore;
        int numberofplayers;

        public void playeramount()
        {
            
            bool amountofplayers1to10 = true;

            //forces int values only 
            while (!int.TryParse(Console.ReadLine(), out numberofplayers))
            {
                Console.Write("This is not valid input. Please enter an integer value: ");
            }
            //amount of players between 2 and 10
            while (amountofplayers1to10 == true)
            {
                if(numberofplayers  <=1 && numberofplayers >11)
                {
                    Console.WriteLine("The max number of players is 10 and the least is 2");
                    playeramount();
                }
                else
                {
                    Console.WriteLine("you have"+ ""+ numberofplayers + ""+ "number of players");
                    amountofplayers1to10 = false;
                }

            }
        }



        public int Playerid { get { return playerID; } set { playerID = value; } }
        public string Playername { get { return playername; } set { playername = value; } }

        public int Playerscore { get { return playerscore; } set { playerscore = value; } }
        public void Player_scores(int score)
        {
            Playerscore += score;

        }



        public void playernames(List<string> playername)
        {
                        
            bool playernamed = true;

            string player1 = "";
            string player2 = "";
            string player3 = "";
            string player4 = "";
            string player5 = "";
            string player6 = "";
            string player7 = "";
            string player8 = "";
            string player9 = "";
            string player10 = "";
            List<string> listofplayers = new List<string> { };
            while (playernamed == true)
            {

                
                Console.WriteLine("now enter each players name");
                foreach (int i in  Enumerable.Range(0,numberofplayers))
                {
                    listofplayers.Add(Console.ReadLine());

                }


            }


        }
        public void playerid(List<string> playerid)
        {
            int playerid1 = 1;
            int playerid2 = 2;
            int playerid3 = 3;
            int playerid4 = 4;
            int playerid5 = 5;
            int playerid6 = 6;
            int playerid7 = 7;
            int playerid8 = 8;
            int playerid9 = 9;
            int playerid10 = 10;
            List<int> listofids = new List<int> { playerid1, playerid2, playerid3, playerid4, playerid5, playerid6, playerid7, playerid8, playerid9, playerid10 };
            
        }
        public void player(List<string> players)
        {
            int i = 0;
            playernames(players);
            List<string> listofplayers = new List<string>();
            //player id 
            playerid(listofplayers);
            //player names
            playernames(players);
            //player score
            Player_scores(Playerscore);
            //playerall
            List<string> playerall = new List<string>();
            foreach (string str in listofplayers.Select(i,numberofplayers))
            {
                
            }

        }
    }
}
