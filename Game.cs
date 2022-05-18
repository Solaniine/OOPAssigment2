using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assigment2
{
    internal class Game
    {

        private static List<int> ThrowDice()
        {
            //the outcome of the dice throw 
            List<int> throwdie = new List<int>();
            //5dice allows for 5 rolls
            RollingDie dice1 = new RollingDie();
            RollingDie dice2 = new RollingDie();
            RollingDie dice3 = new RollingDie();
            RollingDie dice4 = new RollingDie();
            RollingDie dice5 = new RollingDie();
            //list of dice 
            List<RollingDie> diceList = new List<RollingDie>(5) { dice1, dice2, dice3, dice4, dice5 };
            
            int counter = 0;
            //rolls 5 times due to list of dice = 5 
            foreach (var die in diceList)
            {
                //each rolls = one roll of the die 
                int dieface = die.Returndiceroll();
                //adds thrown die 
                throwdie.Add(dieface);
                //shows counter + the roll value 
                Console.WriteLine("Dice " + (counter + 1) + " " + dieface + " ");
                counter++;
            }
            return throwdie;
        }
        private static List<int> Reroll(int repeat)
        {
            List<int> throwdie = new List<int>();
            //5dice allows for 5 rolls
            RollingDie dice1 = new RollingDie();
            RollingDie dice2 = new RollingDie();
            RollingDie dice3 = new RollingDie();
            RollingDie dice4 = new RollingDie();
            RollingDie dice5 = new RollingDie();
            //list of dice 
            List<RollingDie> diceList = new List<RollingDie>(5) { dice1, dice2, dice3, dice4, dice5 };
            //rolls 5 times due to list of dice = 5 
            int couter = 0;
            //each rolls = one roll of the die 
            for (int i = 0; i < diceList.Count; i++)
            {
                // i == 0 or i== 1
                if (i == 0 || i == 1)
                {
                    // the amount on the dice = number of repeats
                    int dieface = repeat;
                    //add the die to the outcome of dice roll
                    throwdie.Add(dieface);
                    //shows counter + the roll value 
                    Console.WriteLine("Dice " + (couter + 1) + " " + dieface + " ");
                    couter++;
                }
                else
                {
                    // diceface = item in list now equals dice roll 
                    int dieface = diceList[i].Returndiceroll();
                    // throwdie add to diceroll
                    throwdie.Add(dieface);
                    //shows counter + the roll value 
                    Console.WriteLine("Dice " + (couter + 1) + " " + dieface + " ");
                    couter++;
                }
            }
            return throwdie;
        }
        public static void Play()
        {
            //playeramount is made into playlist
            List<Player> playerList = playeramount();
            //allows for a break 
            while (true)
            {
                //each player inside of the playeramount is used here
                foreach (var player in playerList)
                {
                    //roll by pressing enter
                    Console.WriteLine(player.PlayerName + " Enter, to roll again ");
                    //reads key stroke
                    Console.ReadKey();
                    //array for thrown dice, 0, player
                    GetScore(ThrowDice(), 0, player);
                    //name + score+ players score
                    Console.WriteLine(player.PlayerName + " Score: " + player.Playerscore);
                    //if playerscore = 50 then game is over 
                    if (player.Playerscore >= 50)
                    {
                        //kills console when player won 
                        Console.WriteLine(player + "won!");
                        Thread.Sleep(5000);
                        System.Environment.Exit(1);


                    }
                }
            }
        }

        private static void GetScore(List<int> dieValues, int counter, Player player)
        {
            int score = 0;
            // creates a dictinonary for the diceroll with key values of pairs. 
            Dictionary<int, int> diceThrow = new Dictionary<int, int>(6)
            {
                {1,0},
                {2,0},
                {3,0},
                {4,0},
                {5,0},
                {6,0}
                };
            //for every value inside of the dice values +1
            foreach (int Value in dieValues)
            {
                diceThrow[Value]++;
            }
            //allows for the ai to roll and rolls from 1 to maxvalue(6)
            int AiValue = diceThrow.Values.Max();
            Console.WriteLine("AI value is: " + AiValue);
            //this is the timing of the numbers 
            if (AiValue == 5)
            {
                player.Player_scoresupdate(12);
            }
            else if (AiValue == 4)
            {
                player.Player_scoresupdate(6);
            }
            else if (AiValue == 3)
            {
                player.Player_scoresupdate(3);
            }
            else if (AiValue == 2)
            {
                
                if (counter < 1)
                {
                    //allows for roll for the 3rd die
                    int repeated = 0;

                    foreach (var pair in diceThrow)
                    {
                        // if equal to 2 then store both values next to each other 
                        if (pair.Value == 2)
                        {
                            repeated = pair.Key;
                        }
                    }
                   
                    Console.WriteLine(repeated + " twice repeated, press enter\n");
                    Console.ReadKey();
                    counter++;

                    List<int> newList = Reroll(repeated);
                    GetScore(newList, counter, player);
                }
            }
            else
            {
                Console.WriteLine("AI won ");
            }
        }
        private static List<Player> playeramount()
        {
            //number of players playing 
            int numberofplayers = 0;
            // allows playerlist to interact
            List<Player> playerlist = new List<Player>();
            //forces int values only 
           
            //amount of players between 2 and 10
            while (true)
            {
                while (!int.TryParse(Console.ReadLine(), out numberofplayers))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                }
                //below 2 or above 11 then repeats playeramount till between values 
                if (numberofplayers < 2 || numberofplayers > 11)
                {
                    Console.WriteLine("The max number of players is 11 and the least is 2");
                    playeramount();
                }
                else
                {
                    Console.WriteLine("you have " + numberofplayers + " " + "number of players");
                    break;
                }

            }
            List<string> listofplayers = new List<string> { };

                Console.WriteLine("now enter each players name");
            //every player can now input their name from range 0 to the amount of players
            foreach (int i in Enumerable.Range(0, numberofplayers))
                {
                //id + 1

                int playerID = i + 1;
                //name == user input
                string playerName = Console.ReadLine();
                //adds id, name and id to the list
               playerlist.Add(new Player(playerID, playerName, 0));
                }
            //returns it back 
            return playerlist;

            
        }
  
    }
}