using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS3
{
    abstract class Weapon
    {
        public string nameOfWeapon;

        public Weapon()
        {
            
        }
        //every weapon can do some kind of a attack depending on user input/AI
        public virtual void CanAttack()
        {
            Console.WriteLine("{0}");
        }
    }
}
