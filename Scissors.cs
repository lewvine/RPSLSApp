using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSApp
{
    internal class Scissors : Gesture
    {
        public Scissors()
        {
            this.name = "Scissors";
        }

        public override int CompareGestures(Gesture gesture)
        {
            switch (gesture.name)
            {
                case "Rock":
                    Console.WriteLine("Rock crushes Scissors");
                    return -1;
                case "Paper":
                    Console.WriteLine("Scissors cuts Paper");
                    return 1;
                case "Spock":
                    Console.WriteLine("Spock smashes Scissors");
                    return -1;
                case "Lizard":
                    Console.WriteLine("Scissors decapitates Lizard");
                    return 1;
                default:
                    Console.WriteLine("You picked the same gesture!");
                    return 0;
            }
        }
    }
}
