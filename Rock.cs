using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSApp
{
    internal class Rock : Gesture
    {
        public Rock()
        {
            this.name = "Rock";
        }

        public override int CompareGestures(Gesture gesture)
        {
            switch (gesture.name)
            {
                case "Scissors":
                    Console.WriteLine("Rock crushes Scissors");
                    return 1;
                case "Paper":
                    Console.WriteLine("Paper covers Rock");
                    return -1;
                case "Spock":
                    Console.WriteLine("Spock vaporizes Rock");
                    return -1;
                case "Lizard":
                    Console.WriteLine("Rock crushes Lizard");
                    return 1;
                default:
                    Console.WriteLine("You picked the same gesture!");
                    return 0;
            }
        }
    }
}
