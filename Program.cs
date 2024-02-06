namespace RPSLSApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            string input = "YES";
            while(input == "YES")
            {
                Console.Clear();
                game.round = 1;
                game.playerOneScore = 0;
                game.playerTwoScore = 0;
                Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock");
                int numberOfPlayers = game.SelectNumberOfPlayers();
                game.SetPlayerNames(numberOfPlayers);
                Console.Clear();
                while (game.playerOneScore < 3 && game.playerTwoScore < 3)
                {
                    game.Round();
                }
                Console.WriteLine("Would you like to play again?  Type 'YES' to play again.");
                input = Console.ReadLine().ToUpper();
            }



        }
    }
}