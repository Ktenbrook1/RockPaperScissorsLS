using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS3
{
    class Program
    {
        static void Main(string[] args)
        {
            int winnerToken = 0;
            do
            {
                Game game = new Game();
                game.Compare();
                Console.WriteLine("------------------------------------------------------------------------");
                if (game.player1.score >= 2)
                {
                    winnerToken++;
                    Console.WriteLine("Player 1 Wins");
                }
                else if (game.player2.score >= 2)
                {
                    winnerToken++;
                    Console.WriteLine("Player 2 Wins");
                }

            } while (winnerToken == 0);
            Console.ReadLine();
        }
    }
}
