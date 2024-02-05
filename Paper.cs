using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSApp
{
    internal class Paper : Gesture
    {
        public Paper()
        {
            this.name = "Paper";
        }

        public override int CompareGestures(Gesture gesture)
        {
            switch (gesture.name)
            {
                case "Scissors":
                    Console.WriteLine("Scissors cuts Paper");
                    return -1;
                case "Rock":
                    Console.WriteLine("Paper covers Rock");
                    return 1;
                case "Spock":
                    Console.WriteLine("Paper disproves Spock");
                    return 1;
                case "Lizard":
                    Console.WriteLine("Lizard eats Paper");
                    return -1;
                default:
                    Console.WriteLine("You picked the same gesture!");
                    return 0;
            }
        }
    }
}
