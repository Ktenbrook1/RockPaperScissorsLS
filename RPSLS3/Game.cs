using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS3
{
    class Game
    {
        //variables "has a"

        public Player player1;
        public Player player2;
        //want to reference the same weapons list but unsure how
        public List<Weapon> weaponsList = new List<Weapon>();

        //con
        public Game()
        {
            WelcomeMessage();
            player1 = new Human();
            player2 = new Computer();
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("Player one picked {0} ", player1.ChoosenGesture1.nameOfWeapon);
            Console.WriteLine("Player two picked {0} ", player2.ChoosenGesture1.nameOfWeapon);
            Console.WriteLine("May the odds be ever in your favor... ");
            Console.WriteLine("------------------------------------------------------------------------");
        }

        //methods "can do"
        public void WelcomeMessage()
        {
            bool show = false;
            if(show = false) {
                Console.WriteLine("\nWelcome to Rock Paper Scissors Lizard Spock!! " +
                    "\n Where the odds of you matching with your opponent are less than 75-80%" +
                    "\n You will be playing against a robot for this game, best 2/3 wins." +
                    "\n Press any key to start");
                Console.WriteLine("------------------------------------------------------------------------");
                Console.ReadKey();
                Console.WriteLine("\n");
                show = true;
            }  
        }
        public void Compare()
        {
            //I notice I could have made this easier on myself but I already wrote it all out and it works so I'm leaving it :)
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
                    player2.score++;
                    if (player2.ChoosenGesture1.nameOfWeapon == "Paper")
                    {
                        Console.WriteLine("Paper covers Rock!");
                    }
                    else
                    {
                        Console.WriteLine("Spock vaporizes Rock!!");
                    }
                }
                else
                {
                    player1.score++;
                    if (player2.ChoosenGesture1.nameOfWeapon == "Scissors")
                    {
                        Console.WriteLine("Rock crushes Scissors");
                    }
                    else
                    {
                        Console.WriteLine("Rock crushes Lizard");
                    }
                }
            }
            if (player1.ChoosenGesture1.nameOfWeapon == "Paper")
            {
                if (player2.ChoosenGesture1.nameOfWeapon == "Scissors" || player2.ChoosenGesture1.nameOfWeapon == "Spock")
                {
                    player2.score++;
                    if (player2.ChoosenGesture1.nameOfWeapon == "Scissors")
                    {
                        Console.WriteLine("Scissors cuts Paper");
                    }
                    else
                    {
                        Console.WriteLine("Spock disaproves Paper");
                    }
                }
                else
                {
                    player1.score++;
                    if (player2.ChoosenGesture1.nameOfWeapon == "Lizard")
                    {
                        Console.WriteLine("Lizard eats Paper");
                    }
                    else
                    {
                        Console.WriteLine("Paper covers Rock");
                    }
                }
            }
            if (player1.ChoosenGesture1.nameOfWeapon == "Scissors")
            {
                if (player2.ChoosenGesture1.nameOfWeapon == "Spock" || player2.ChoosenGesture1.nameOfWeapon == "Rock")
                {
                    player2.score++;
                    if (player2.ChoosenGesture1.nameOfWeapon == "Spock")
                    {
                        Console.WriteLine("Spock smashes Scissors");
                    }
                    else
                    {
                        Console.WriteLine("Rock crushes Scissors");
                    }

                }
                else
                {
                    player1.score++;
                    if (player2.ChoosenGesture1.nameOfWeapon == "Lizard")
                    {
                        Console.WriteLine("Scissors decapitates Lizard");
                    }
                    else
                    {
                        Console.WriteLine("Scissors cuts Paper");
                    }
                }
            }
            if (player1.ChoosenGesture1.nameOfWeapon == "Lizard")
            {
                if (player2.ChoosenGesture1.nameOfWeapon == "Rock" || player2.ChoosenGesture1.nameOfWeapon == "Scissors")
                {
                    player2.score++;
                    if (player2.ChoosenGesture1.nameOfWeapon == "Rock")
                    {
                        Console.WriteLine("Rock crushes Lizard");
                    }
                    else
                    {
                        Console.WriteLine("Scissors decapitates Lizard");
                    }
                }
                else
                {
                    player1.score++;
                    if (player2.ChoosenGesture1.nameOfWeapon == "Spock")
                    {
                        Console.WriteLine("Lizard poisons Spock");
                    }
                    else
                    {
                        Console.WriteLine("Lizard eats Paper");
                    }
                }
            }
            if (player1.ChoosenGesture1.nameOfWeapon == "Spock")
            {
                if (player2.ChoosenGesture1.nameOfWeapon == "Lizard" || player2.ChoosenGesture1.nameOfWeapon == "Paper")
                {
                    player2.score++;
                    if (player2.ChoosenGesture1.nameOfWeapon == "Lizard")
                    {
                        Console.WriteLine("Lizard poisons Spock ");
                    }
                    else
                    {
                        Console.WriteLine("Paper disapproves Spock");
                    }
                }
                else
                {
                    player1.score++;
                    if (player2.ChoosenGesture1.nameOfWeapon == "Rock")
                    {
                        Console.WriteLine("Spock vaporizes Rock");
                    }
                    else
                    {
                        Console.WriteLine("Spock smashes Scissors");
                    }
                }
            }
        }
    }
}

