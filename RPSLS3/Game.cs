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

        List<Weapon> weaponsLists;

        public int usersChoice;
        //con

        //methods "can do"
        public void GetUsersWeapon()
        {
            
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock!! " +
                "\n Where the odds of you matching with your opponent are less than 75-80%" +
                "\n You will be playing against a robot for this game, best 2/3 wins." +
                "\n Press any key to start");
            Console.ReadKey();
            Console.WriteLine("Enter the number of your prefered weapon. Choose Wisely" +
                "\n 1. Rock" +
                "\n 2. Paper" +
                "\n 3. Scissors" +
                "\n 4. Lizard" +
                "\n 5. Spock");
            int userChoice = 1;
            GetNamesForWeapons(userChoice);
            int aIChoice = 2;
        //    int aIChoice = GetAIWeapon();
        //    GetNamesForWeapons(aIChoice);
        //}
        //public int GetAIWeapon()
        //{
        //    int[] aIWeapon = new int[5];
        //    Random random = new Random();
            
        //    int aIChoice = random.Next(aIWeapon.Length);
        //    return aIChoice;
        }
        public void GetNamesForWeapons(int Choice)
        {
            //if and else statements will go here
            if(Choice == 1)
            {
               rock = new Rock();
            }
            else if(Choice == 2)
            {
                paper = new Paper();
            }

        }
        public void Compare()
        {
            //compare the two inputs for a given round
        }
    }
}
