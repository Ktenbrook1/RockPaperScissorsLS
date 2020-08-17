using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS3
{
    class Human : Player
    {
        
        public Human()
        {
            
        }
        public override void ChooseGesture()
        {
            Console.WriteLine("Enter the number of your prefered weapon. Choose Wisely" +
             "\n 1. Rock" +
             "\n 2. Paper" +
             "\n 3. Scissors" +
             "\n 4. Lizard" +
             "\n 5. Spock");
             var choice = Console.ReadLine();
            int userChoice;
            while(!int.TryParse(choice, out userChoice)){
                Console.WriteLine("This is not a number from 1-5 please try again...");
                choice = Console.ReadLine();
            }
            ChoosenGesture1 = Choices[userChoice - 1];
        }
    }
}

