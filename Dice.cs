using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment2
{
    internal class Dice
    {
        private int dieId;
        private int dieFaces;


        public static List<int> roll_dice()
        {
            List<int> roll = new List<int>();
            Random random = new Random();
            for (int i = 0; i < 6; i++)
            {
                roll.Add(random.Next(1, 7));
            }

            return roll;
        }
        
    }
}
