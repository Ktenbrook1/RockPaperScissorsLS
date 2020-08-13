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

        //Going to take out because they go into the constructor
        Rock rock;
        Paper paper;
        Scissors scissors;
        Lizard lizard;
        Spock spock;

        Player player1;
        Player player2;
  
        //con
        public Game()
        {
            player1 = new Human();
            player2 = new Computer();
            WelcomeMessage();
        }

        //methods "can do"
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock!! " +
                "\n Where the odds of you matching with your opponent are less than 75-80%" +
                "\n You will be playing against a robot for this game, best 2/3 wins." +
                "\n Press any key to start");
            Console.ReadKey();
        }
     
        public void GetNamesForWeapons(int Choice)
        {
            //if and else statements will go here
            bool keepgoing = false;
            do
            {
                if (Choice == 1)
                {
                    rock = new Rock();
                }
                else if (Choice == 2)
                {
                    paper = new Paper();
                }
                else if (Choice == 3)
                {
                    scissors = new Scissors();
                }
                else if (Choice == 4)
                {
                    lizard = new Lizard();
                }
                else if (Choice == 5)
                {
                    spock = new Spock();
                }
                else
                {
                    Console.WriteLine("That responce was notone of the following options, please try again");
                    keepgoing = true;
                }
            } while (keepgoing);

        }
        public void Compare()
        {
            //compare the two inputs for a given round
        }
    }
}
