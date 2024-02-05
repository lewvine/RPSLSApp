using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace RPSLSApp
{
    internal class Game
    {
        public int playerOneScore;
        public int playerTwoScore;
        public Player playerOne;
        public Player playerTwo;
        public int round = 1;

        public Game(){}

        public int SelectNumberOfPlayers()
        {
            Console.WriteLine("Would you like to play a one player (1) game or a two player game (2)");
            int input = 0;
            Int32.TryParse(Console.ReadLine(), out input);
            while (input != 1 && input != 2)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock");
                Console.WriteLine("Please try again.  Select 1 for a one player game or 2 for a two player game;");
                Int32.TryParse(Console.ReadLine(), out input);
            };
            return input;
        }

        public void SetPlayerNames(int numberOfPlayers)
        {
            Console.Write("Player 1 please input your name:");
            string name = Console.ReadLine();
            this.playerOne = new Human(name);

            if (numberOfPlayers == 1)
            {
                this.playerTwo = new AI();
            }
            else
            {
                Console.Write("Player 2 please input your name:");
                name = Console.ReadLine();
                this.playerTwo = new Human(name);
            }
        }

        public void Round()
        {
            Console.Clear();
            Console.WriteLine($"ROUND #{this.round}:");
            playerOne.SetCurrentGesture();
            playerTwo.SetCurrentGesture();
            int winner = playerOne.currentGesture.CompareGestures(playerTwo.currentGesture);
            switch(winner)
            {
                case 1:
                    playerOneScore++;
                    Console.WriteLine($"{playerOne.name} wins round!");
                    break;
                case -1:
                    playerTwoScore++;
                    Console.WriteLine($"{playerTwo.name} wins round!");
                    break;
                case 0:
                default:
                    break;
            }
            Console.WriteLine($"The score is {playerOneScore} - {playerTwoScore}");
            this.round++;
            Console.ReadLine();
        }


    }
}
