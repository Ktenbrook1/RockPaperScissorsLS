using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RPSLS3
{
    class Game
    {
        //variables "has a"
        public Player player1;
        public Player player2;
      
        public List<Weapon> weaponsList = new List<Weapon>();

        //con
        public Game()
        {
            WelcomeMessage();
            player1 = new Human();
            ChoosePlayer();
        }

        //methods "can do"
        public void WelcomeMessage()
        {  
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock!! " +
                "\nWhere the odds of you matching with your opponent are less than 75-80%" +
                "\nYou will be playing against a robot for this game, best 2/3 wins." +
                "\nPress any key to start");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.ReadKey();
            Console.WriteLine("\n");
        }

        public void ChoosePlayer()
        {
            bool tryagain;
            Console.WriteLine("Do you want to play against another player or the computer? \nEnter '1' for another player or '2' to play against the computer");
            do
            {
                tryagain = false;
                string playAgainst = Console.ReadLine();
                if (playAgainst == "1")
                {
                    player2 = new Human();
                }
                else if (playAgainst == "2")
                {
                    player2 = new Computer();
                }
                else
                {
                    Console.WriteLine("That was not a valid player option. Please try again... ");
                    tryagain = true;
                }
            } while(tryagain);
           
        }
        public void Compare()
        {
            //need to get it to where its doesnt go into the other if statements froma tie :(
            if (player1.ChoosenGesture1.nameOfWeapon == player2.ChoosenGesture1.nameOfWeapon)
            {
                {
                    Console.WriteLine("It was a tie!! Try Again!");
                    
                }
            }
            if (player1.ChoosenGesture1.nameOfWeapon == "Rock")
            {
                if (player2.ChoosenGesture1.nameOfWeapon == "Paper" || player2.ChoosenGesture1.nameOfWeapon == "Spock")
                {
                    if (player2.ChoosenGesture1.nameOfWeapon == "Paper")
                    {
                        Console.WriteLine("Paper covers Rock!");
                        P2EarnsPoint();
                    }
                    else
                    {
                        Console.WriteLine("Spock vaporizes Rock!!");
                        P2EarnsPoint();
                    }
                }
                else
                {
                    if (player2.ChoosenGesture1.nameOfWeapon == "Scissors")
                    {
                        Console.WriteLine("Rock crushes Scissors");
                        P1EarnsPoint();
                    }
                    else if(player2.ChoosenGesture1.nameOfWeapon == "Lizard")
                    {
                        Console.WriteLine("Rock crushes Lizard");
                        P1EarnsPoint();
                    }
                }
            }
            if (player1.ChoosenGesture1.nameOfWeapon == "Paper")
            {
                if (player2.ChoosenGesture1.nameOfWeapon == "Scissors" || player2.ChoosenGesture1.nameOfWeapon == "Spock")
                {
                    if (player2.ChoosenGesture1.nameOfWeapon == "Scissors")
                    {
                        Console.WriteLine("Scissors cuts Paper");
                        P2EarnsPoint();
                    }
                    else
                    {
                        Console.WriteLine("Spock disaproves Paper");
                        P2EarnsPoint();
                    }
                }
                else
                {
                    if (player2.ChoosenGesture1.nameOfWeapon == "Lizard")
                    {
                        Console.WriteLine("Lizard eats Paper");
                        P1EarnsPoint();
                    }
                    else if(player2.ChoosenGesture1.nameOfWeapon == "Rock")
                    {
                        Console.WriteLine("Paper covers Rock");
                        P1EarnsPoint();
                    }
                }
            }
            if (player1.ChoosenGesture1.nameOfWeapon == "Scissors")
            {
                if (player2.ChoosenGesture1.nameOfWeapon == "Spock" || player2.ChoosenGesture1.nameOfWeapon == "Rock")
                {
                    if (player2.ChoosenGesture1.nameOfWeapon == "Spock")
                    {
                        Console.WriteLine("Spock smashes Scissors");
                        P2EarnsPoint();
                    }
                    else
                    {
                        Console.WriteLine("Rock crushes Scissors");
                        P2EarnsPoint();
                    }

                }
                else
                {
                    if (player2.ChoosenGesture1.nameOfWeapon == "Lizard")
                    {
                        Console.WriteLine("Scissors decapitates Lizard");
                        P1EarnsPoint();
                    }
                    //required to write a else if or else, for example, if the players both get scissors then this else would still run when it doesnt need to
                    else if(player2.ChoosenGesture1.nameOfWeapon == "Paper")
                    {
                        Console.WriteLine("Scissors cuts Paper");
                        P1EarnsPoint();
                    }
                }
            }
            if (player1.ChoosenGesture1.nameOfWeapon == "Lizard")
            {
                if (player2.ChoosenGesture1.nameOfWeapon == "Rock" || player2.ChoosenGesture1.nameOfWeapon == "Scissors")
                {
                    if (player2.ChoosenGesture1.nameOfWeapon == "Rock")
                    {
                        Console.WriteLine("Rock crushes Lizard");
                        P2EarnsPoint();
                    }
                    else
                    { 
                        Console.WriteLine("Scissors decapitates Lizard");
                        P2EarnsPoint();
                    }
                }
                else
                {
                    if (player2.ChoosenGesture1.nameOfWeapon == "Spock")
                    {
                        Console.WriteLine("Lizard poisons Spock");
                        P1EarnsPoint();
                    }
                    else if(player2.ChoosenGesture1.nameOfWeapon == "Paper")
                    {
                        Console.WriteLine("Lizard eats Paper");
                        P1EarnsPoint();
                    }
                }
            }
            if (player1.ChoosenGesture1.nameOfWeapon == "Spock")
            {
                if (player2.ChoosenGesture1.nameOfWeapon == "Lizard" || player2.ChoosenGesture1.nameOfWeapon == "Paper")
                {
                    if (player2.ChoosenGesture1.nameOfWeapon == "Lizard")
                    {
                        Console.WriteLine("Lizard poisons Spock ");
                        P2EarnsPoint();
                    }
                    else
                    {
                        Console.WriteLine("Paper disapproves Spock");
                        P2EarnsPoint();
                    }
                }
                else
                {
                    if (player2.ChoosenGesture1.nameOfWeapon == "Rock")
                    {
                        Console.WriteLine("Spock vaporizes Rock");
                        P1EarnsPoint();
                    }
                    else if(player2.ChoosenGesture1.nameOfWeapon == "Scissors")
                    {
                        Console.WriteLine("Spock smashes Scissors");
                        P1EarnsPoint();
                    }
                }
            }
            Console.WriteLine("{0} now has a score of {1} and {2} has a score of {3} ",player1.name, player1.score, player2.name, player2.score);
            Console.WriteLine("----------------------------------------------------------------------");
        }

        public void P1EarnsPoint()
        {
            Console.WriteLine("{0} earns a point", player1.name);
            player1.score++;
        }
        public void P2EarnsPoint()
        {
            Console.WriteLine("{0} earns a point", player2.name);
            player2.score++;
        }
        
        public void RunGame()
        {
            do
            {
                player1.ChooseGesture();
                player2.ChooseGesture();
                Console.WriteLine("------------------------------------------------------------------------");
                Console.WriteLine("{0} picked {1} ",player1.name, player1.ChoosenGesture1.nameOfWeapon);
                Console.WriteLine("{0} picked {1} ",player2.name, player2.ChoosenGesture1.nameOfWeapon);
                Console.WriteLine("May the odds be ever in your favor... ");
                Console.WriteLine("------------------------------------------------------------------------");
                Compare();
            } while (player1.score < 2 && player2.score < 2);

            if (player1.score == 2)
            {
                Console.WriteLine("{0} Wins!", player1.name);
                Console.ReadLine();
            }
            else if (player2.score == 2)
            {
                Console.WriteLine("{0} Wins!", player2.name);
                Console.ReadLine();
            }
        }
    }
}

