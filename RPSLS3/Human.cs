using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS3
{
    class Human : Player
    {
        int userChoice;
        public Human()
        {
            ChooseGesture();
        }
        public override void ChooseGesture()
        {
            Console.WriteLine("Enter the number of your prefered weapon. Choose Wisely" +
             "\n 1. Rock" +
             "\n 2. Paper" +
             "\n 3. Scissors" +
             "\n 4. Lizard" +
             "\n 5. Spock");
            userChoice = int.Parse(Console.ReadLine());
            ChoosenGesture1 = Choices[userChoice - 1];
        }
        //public override void GetNamesForWeapons(int Choice)
        //{
        //    //if and else statements will go here
        //    bool keepgoing = false;
        //    do
        //    {
        //        if (Choice == 1)
        //        {
        //            Weapon rock = new Rock();
        //            weaponsList.Add(rock);
        //        }
        //        else if (Choice == 2)
        //        {
        //            Weapon paper = new Paper();
        //            weaponsList.Add(paper);
        //        }
        //        else if (Choice == 3)
        //        {
        //            Weapon scissors = new Scissors();
        //            weaponsList.Add(scissors);
        //        }
        //        else if (Choice == 4)
        //        {
        //            Weapon lizard = new Lizard();
        //            weaponsList.Add(lizard);
        //        }
        //        else if (Choice == 5)
        //        {
        //            Weapon spock = new Spock();
        //            weaponsList.Add(spock);
        //        }
        //        else
        //        {
        //            Console.WriteLine("That responce was notone of the following options, please try again");
        //            keepgoing = true;
        //        }
        //    } while (keepgoing);
        }
    }

