using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment2
{

    internal class RollingDie
    {
       
        private int sidescount = 6;
      
        public int numberoffaces
        {
            get { return sidescount; }
        }
        public int Returndiceroll()
        {
            
            Random random = new Random();
            return random.Next(1, sidescount + 1);
        }

    }
        


    
}