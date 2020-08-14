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
        //public void GetNamesForWeapons(int Choice)
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
