namespace RPSLSApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock");
            int numberOfPlayers = game.SelectNumberOfPlayers();
            game.SetPlayerNames(numberOfPlayers);
            Console.Clear();
            while(game.playerOneScore < 3 || game.playerTwoScore < 3)
            {
                game.Round();
            }
        }
    }
}