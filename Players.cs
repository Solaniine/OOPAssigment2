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
        public void player(int id, string name, int score)
        {
            playerID = id;
            playername = name;
            playerscore = score;
            

           
        }
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


                while (numberofplayers <= 1 && numberofplayers > 11)
                {
                    Console.WriteLine("you can not have one or below 1 players");
                    playeramount();
                }

                while (numberofplayers < 11)
                {
                    Console.WriteLine("number of people playing: " + numberofplayers);
                    amountofplayers1to10 = false;
                    break;
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
            List<string> listofplayers = new List<string> { player1, player2, player3, player4, player5, player6, player7, player8, player9, player10 };
            while (playernamed == true)
            {

                
                Console.WriteLine("now enter each players name");
                foreach (int i in  Enumerable.Range(0,numberofplayers))
                {
                  listofplayers[i] = Console.ReadLine();

                }


            }


        }

    }
}
