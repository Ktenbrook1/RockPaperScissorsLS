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

        }
        public override int ChooseGesture()
        {
            Console.WriteLine("Enter the number of your prefered weapon. Choose Wisely" +
             "\n 1. Rock" +
             "\n 2. Paper" +
             "\n 3. Scissors" +
             "\n 4. Lizard" +
             "\n 5. Spock");
            userChoice = int.Parse(Console.ReadLine());
            return userChoice;
        }
    }
}
