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
                    // throwdie adds diceroll
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

            List<Player> playerList = playeramount();
            while (true)
            {
                foreach (var player in playerList)
                {
                    Console.WriteLine("It's " + player.PlayerName + "to roll \r\nPress enter to roll");
                    Console.ReadKey();
                    GetScore(ThrowDice(), 0, player);
                    Console.WriteLine(player.PlayerName + "'s Score: " + player.Playerscore);
                    if (player.Playerscore >= 50)
                    {
                        Console.WriteLine("Congrats, " + player + "won!");
                        break;
                    }
                }
            }
        }

        
        private static List<Player> playeramount()
        {

            int numberofplayers = 0;

            List<Player> playerlist = new List<Player>();
            //forces int values only 
           
            //amount of players between 2 and 10
            while (true)
            {
                while (!int.TryParse(Console.ReadLine(), out numberofplayers))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                }

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
            foreach (int i in Enumerable.Range(0, numberofplayers))
                {
                    int playerID = i + 1;
                    listofplayers.Add(Console.ReadLine());
                    string playerName = Console.ReadLine();
                    playerlist.Add(new Player(playerID, playerName, 0));
                }
            return playerlist;

            
        }
        private static void GetScore(List<int> dieValues, int counter, Player player)
        {
            int score = 0;
            Dictionary<int, int> diceThrow = new Dictionary<int, int>(6)
            {
                {1,0},
                {2,0},
                {3,0},
                {4,0},
                {5,0},
                {6,0}
                };
            foreach (int dieValue in dieValues)
            {
                diceThrow[dieValue]++;
            }

            int maxValue = diceThrow.Values.Max();
            Console.WriteLine("Max value is: " + maxValue);

            if (maxValue == 5)
            {
                player.Player_scoresupdate(12);
            }
            else if (maxValue == 4)
            {
                player.Player_scoresupdate(6);
            }
            else if (maxValue == 3)
            {
                player.Player_scoresupdate(3);
            }
            else if (maxValue == 2)
            {
                if (counter < 1)
                {
                
                    int repeatedValue = 0;

                    foreach (var pair in diceThrow)
                    {
                        if (pair.Value == 2)
                        {
                            repeatedValue = pair.Key;
                        }
                    }

                    Console.WriteLine(repeatedValue + " is repeated twice.\nPress enter to re-roll.......");
                    Console.ReadKey();
                    counter++;

                    List<int> newList = Reroll(repeatedValue);
                    GetScore(newList, counter, player);
                }
            }
            else
            {
                Console.WriteLine("Better luck next time!");
            }
        }
    }
}