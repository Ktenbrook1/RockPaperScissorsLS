using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS3
{
    abstract class Player
    {
        public int score;
        List<Weapon> weaponsList;

        public Player()
        {

        }

        public abstract int ChooseGesture();
       
    }
}
