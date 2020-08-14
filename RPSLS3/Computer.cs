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
            ChooseGesture();
        }
        public override void ChooseGesture()
        {
            int[] aIWeapon = new int[5];
            Random random = new Random();

            int aIChoice = random.Next(aIWeapon.Length);
            ChoosenGesture1 = Choices[aIChoice];
        }
        //should I put all the responces into a list of weapons for just the player/comp by himself of for both at the same time
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

        //}
    }
}
