using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS3
{
    class Computer : Player
    {

        public Computer()
        {
            ChooseGesture();
            weaponsList = new List<Weapon>;
        }
        public override int ChooseGesture()
        {
            int[] aIWeapon = new int[5];
            Random random = new Random();

            int aIChoice = random.Next(aIWeapon.Length);
            return aIChoice;
        }
    }
}
