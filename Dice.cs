using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment2
{

    internal class RollingDie
    {
        private Random random;
        private int sidescount;

        public RollingDie()
        {
            sidescount = 6;
            random = new Random();
        }
        public RollingDie(int sidesCount)
        {
            this.sidescount = sidesCount;
            random = new Random();
        }
        public int Returndiceroll()
        {
           return random.Next(1, sidescount + 1);
        }

    }
        


    
}