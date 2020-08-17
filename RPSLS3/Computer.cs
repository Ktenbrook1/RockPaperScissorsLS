using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace RPSLS3
{
    class Computer : Player
    { 
        public Computer()
        {
            
        }
        public override void ChooseGesture()
        {
            int[] aIWeapon = new int[5];
            Random random = new Random();

            int aIChoice = random.Next(aIWeapon.Length);
            ChoosenGesture1 = Choices[aIChoice];
        }
    }
}
