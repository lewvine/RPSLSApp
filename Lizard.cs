using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSApp
{
    internal class Lizard : Gesture
    {
        public Lizard()
        {
            this.name = "Lizard";
        }

        public override int CompareGestures(Gesture gesture)
        {
            switch (gesture.name)
            {
                case "Scissors":
                    Console.WriteLine("Scissors decapitate Lizard");
                    return -1;
                case "Rock":
                    Console.WriteLine("Rock crushes Lizard");
                    return -1;
                case "Spock":
                    Console.WriteLine("Lizard poisons Spock");
                    return 1;
                case "Paper":
                    Console.WriteLine("Lizard eats Paper");
                    return 1;
                default:
                    Console.WriteLine("You picked the same gesture!");
                    return 0;
            }
        }
    }
}
