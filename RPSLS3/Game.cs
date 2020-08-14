using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS3
{
    class Game
    {
        //variables "has a"

        Player player1;
        Player player2;
        //want to reference the same weapons list but unsure how
        public List<Weapon> weaponsList = new List<Weapon>();

        //con
        public Game()
        {
            WelcomeMessage();
            
            player1 = new Human();
            player2 = new Computer();
            Compare();
        }

        //methods "can do"
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock!! " +
                "\n Where the odds of you matching with your opponent are less than 75-80%" +
                "\n You will be playing against a robot for this game, best 2/3 wins." +
                "\n Press any key to start");
            Console.ReadKey();
            Console.WriteLine("\n");
            
        }
        public void Compare()
        {
            //compare the two inputs for a given round
            if (player1.ChoosenGesture1.nameOfWeapon == "Rock" && player2.ChoosenGesture1.nameOfWeapon == "Paper" 
                || player1.ChoosenGesture1.nameOfWeapon == "Paper" && player2.ChoosenGesture1.nameOfWeapon == "Rock")
            {
                if(player1.ChoosenGesture1.nameOfWeapon == "Paper")
                {
                    player1.score++;
                }
                else
                {
                    player2.score++;
                }
                
            }

        }
    }
}
