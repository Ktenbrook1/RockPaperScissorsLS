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
            Console.WriteLine("Do you want to play against another player or the computer? \nEnter '1' for another player or '2'");
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
                        player2.score++;
                        Console.WriteLine("Paper covers Rock!");
                        Console.WriteLine("Player 2 earns a point");
                    }
                    else
                    {
                        player2.score++;
                        Console.WriteLine("Spock vaporizes Rock!!");
                        Console.WriteLine("Player 2 earns a point");
                    }
                }
                else
                {
                    if (player2.ChoosenGesture1.nameOfWeapon == "Scissors")
                    {
                        player1.score++;
                        Console.WriteLine("Rock crushes Scissors");
                        Console.WriteLine("Player 1 earns a point");
                    }
                    else if(player2.ChoosenGesture1.nameOfWeapon == "Lizard")
                    {
                        player1.score++;
                        Console.WriteLine("Rock crushes Lizard");
                        Console.WriteLine("Player 1 earns a point");
                    }
                }
            }
            if (player1.ChoosenGesture1.nameOfWeapon == "Paper")
            {
                if (player2.ChoosenGesture1.nameOfWeapon == "Scissors" || player2.ChoosenGesture1.nameOfWeapon == "Spock")
                {
                    if (player2.ChoosenGesture1.nameOfWeapon == "Scissors")
                    {
                        player2.score++;
                        Console.WriteLine("Scissors cuts Paper");
                        Console.WriteLine("Player 2 earns a point");
                    }
                    else
                    {
                        player2.score++;
                        Console.WriteLine("Spock disaproves Paper");
                        Console.WriteLine("Player 2 earns a point");
                    }
                }
                else
                {
                    if (player2.ChoosenGesture1.nameOfWeapon == "Lizard")
                    {
                        Console.WriteLine("Lizard eats Paper");
                        Console.WriteLine("Player 1 earns a point");
                        player1.score++;
                    }
                    else if(player2.ChoosenGesture1.nameOfWeapon == "Rock")
                    {
                        Console.WriteLine("Paper covers Rock");
                        Console.WriteLine("Player 1 earns a point");
                        player1.score++;
                    }
                }
            }
            if (player1.ChoosenGesture1.nameOfWeapon == "Scissors")
            {
                if (player2.ChoosenGesture1.nameOfWeapon == "Spock" || player2.ChoosenGesture1.nameOfWeapon == "Rock")
                {
                    if (player2.ChoosenGesture1.nameOfWeapon == "Spock")
                    {
                        player2.score++;
                        Console.WriteLine("Spock smashes Scissors");
                        Console.WriteLine("Player 2 earns a point");
                    }
                    else
                    {
                        player2.score++;
                        Console.WriteLine("Rock crushes Scissors");
                        Console.WriteLine("Player 2 earns a point");
                    }

                }
                else
                {
                    if (player2.ChoosenGesture1.nameOfWeapon == "Lizard")
                    {
                        player1.score++;
                        Console.WriteLine("Scissors decapitates Lizard");
                        Console.WriteLine("Player 1 earns a point");
                    }
                    //required to write a else if or else, for example, if the players both get scissors then this else would still run when it doesnt need to
                    else if(player2.ChoosenGesture1.nameOfWeapon == "Paper")
                    {
                        player1.score++;
                        Console.WriteLine("Scissors cuts Paper");
                        Console.WriteLine("Player 1 earns a point");
                    }
                }
            }
            if (player1.ChoosenGesture1.nameOfWeapon == "Lizard")
            {
                if (player2.ChoosenGesture1.nameOfWeapon == "Rock" || player2.ChoosenGesture1.nameOfWeapon == "Scissors")
                {
                    if (player2.ChoosenGesture1.nameOfWeapon == "Rock")
                    {
                        player2.score++;
                        Console.WriteLine("Rock crushes Lizard");
                        Console.WriteLine("Player 2 earns a point");
                    }
                    else
                    {
                        player2.score++;
                        Console.WriteLine("Scissors decapitates Lizard");
                        Console.WriteLine("Player 2 earns a point");
                    }
                }
                else
                {
                    player1.score++;
                    if (player2.ChoosenGesture1.nameOfWeapon == "Spock")
                    {
                        Console.WriteLine("Lizard poisons Spock");
                        Console.WriteLine("Player 1 earns a point");
                    }
                    else if(player2.ChoosenGesture1.nameOfWeapon == "Paper")
                    {
                        Console.WriteLine("Lizard eats Paper");
                        Console.WriteLine("Player 1 earns a point");
                    }
                }
            }
            if (player1.ChoosenGesture1.nameOfWeapon == "Spock")
            {
                if (player2.ChoosenGesture1.nameOfWeapon == "Lizard" || player2.ChoosenGesture1.nameOfWeapon == "Paper")
                {
                    if (player2.ChoosenGesture1.nameOfWeapon == "Lizard")
                    {
                        player2.score++;
                        Console.WriteLine("Lizard poisons Spock ");
                        Console.WriteLine("Player 2 earns a point");
                    }
                    else
                    {
                        player2.score++;
                        Console.WriteLine("Paper disapproves Spock");
                        Console.WriteLine("Player 2 earns a point");
                    }
                }
                else
                {
                    if (player2.ChoosenGesture1.nameOfWeapon == "Rock")
                    {
                        player1.score++;
                        Console.WriteLine("Spock vaporizes Rock");
                        Console.WriteLine("Player 1 earns a point");
                    }
                    else if(player2.ChoosenGesture1.nameOfWeapon == "Scissors")
                    {
                        player1.score++;
                        Console.WriteLine("Spock smashes Scissors");
                        Console.WriteLine("Player 1 earns a point");
                    }
                }
            }
            Console.WriteLine("Player 1 now has a score of {0} points and Player two has {1} points", player1.score, player2.score);
            Console.WriteLine("----------------------------------------------------------------------");
        }
        
        public void RunGame()
        {
            do
            {
                player1.ChooseGesture();
                player2.ChooseGesture();
                Console.WriteLine("------------------------------------------------------------------------");
                Console.WriteLine("Player one picked {0} ", player1.ChoosenGesture1.nameOfWeapon);
                Console.WriteLine("Player two picked {0} ", player2.ChoosenGesture1.nameOfWeapon);
                Console.WriteLine("May the odds be ever in your favor... ");
                Console.WriteLine("------------------------------------------------------------------------");
                Compare();
            } while (player1.score < 2 && player2.score < 2);

            if (player1.score == 2)
            {
                Console.WriteLine("Player 1 Wins");
                Console.ReadLine();
            }
            else if (player2.score == 2)
            {
                Console.WriteLine("Player 2 Wins");
                Console.ReadLine();
            }
        }
    }
}

