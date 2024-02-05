using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RPSLSApp
{
    internal class Spock : Gesture
    {
        public Spock()
        {
            this.name = "Spock";
        }

        public override int CompareGestures(Gesture gesture)
        {
            switch(gesture.name)
            {
                case "Rock":
                    Console.WriteLine("Spock vaporizes Rock");
                    return 1;        
                case "Paper":
                    Console.WriteLine("Paper disproves Spock");
                    return -1;
                case "Scissors":
                    Console.WriteLine("Spock smashes Scissors");
                    return 1;
                case "Lizard":
                    Console.WriteLine("Lizard poisons Spock");
                    return -1;
                default:
                    Console.WriteLine("You picked the same gesture!");
                    return 0;
            }
            
        }
    }
}
