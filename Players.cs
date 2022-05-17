using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment2
{
    public class Players
    {
        private int playerID;

        private int playerscore;
        

        public static void playeramount()
        {
            int numberofplayers;

            bool amountofplayers1to10 = true;

            //forces int values only 
            while (!int.TryParse(Console.ReadLine(), out numberofplayers))
            {
                Console.Write("This is not valid input. Please enter an integer value: ");
            }
            //amount of players between 2 and 10
            while (amountofplayers1to10 == true)
            {
                if(numberofplayers  <2 && numberofplayers > 4)
                {
                    Console.WriteLine("The max number of players is 3 and the least is 2");
                    playeramount();
                }
                if (numberofplayers < 4)
                    {
                    Console.WriteLine("you have "+ numberofplayers + " "+ "number of players");
                    amountofplayers1to10 = false;
                    }

            }
        }
        public void playernames(List<string> list)
        {
            List<string> listofplayers = new List<string> { };
            bool playernamed = true;

            string player1 = "";
            string player2 = "";
            string player3 = "";

            
            while (playernamed == true)
            {

                
                Console.WriteLine("now enter each players name");
                foreach (int i in  Enumerable.Range(0,numberofplayers))
                {
                    listofplayers.Add(Console.ReadLine());

                }


            }


        }

        }
        public int Playerscore { get { return playerscore; } set { playerscore = value; } }
        public void Player_scoresupdate(int score)
        {

            Playerscore += score;

        }

        public void playerid(List<string> playerid)
        {
            int playerid1 = 1;
            int playerid2 = 2;
            int playerid3 = 3;

            List<int> listofids = new List<int> { playerid1, playerid2, playerid3};
            
        }
          
    }
}