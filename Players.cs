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


                while (numberofplayers <= 1)
                {
                    Console.WriteLine("you can not have one or below 1 players");
                    numberofplayers = int.Parse(Console.ReadLine());
                }
                while (numberofplayers > 11)
                {
                    Console.WriteLine("you can not have above 10 players ");
                    numberofplayers = int.Parse(Console.ReadLine());
                }


                while (numberofplayers < 11)
                {
        
                    Console.WriteLine("number of people playing: " + numberofplayers);
                    amountofplayers1to10 = false;
                    break;
                }



            }

            
        }
        public void playernames()
        {

            bool playernamed = true;

            while (playernamed == true)
            {




            }


        }

    }
}
