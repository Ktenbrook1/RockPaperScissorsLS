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
        public List<Weapon> Choices;
        public Weapon ChoosenGesture1;
        public string name;

        public Player()
        {
            Choices = new List<Weapon>();
            Choices.Add(new Rock());
            Choices.Add(new Paper());
            Choices.Add(new Scissors());
            Choices.Add(new Lizard());
            Choices.Add(new Spock());
            
        }

        public abstract void ChooseGesture();
       
        }
    }
