using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSApp
{
    internal class Human : Player
    {
        public Human(string name) : base()
        {
            this.name = name;
        }

        public override void SetCurrentGesture()
        {
            bool validInput = false;
            int input = 0;
            while(!validInput)
            {
                Console.WriteLine($"{this.name} please choose a gesture");
                Console.WriteLine("Select (1) for Rock");
                Console.WriteLine("Select (2) for Paper");
                Console.WriteLine("Select (3) for Scissors");
                Console.WriteLine("Select (4) for Lizard");
                Console.WriteLine("Select (5) for Spock");
                Int32.TryParse(Console.ReadLine(), out input);
                if(input == 1 || input == 2 || input == 3 || input == 4 || input == 5)
                {
                    validInput = true;
                }
            }
            switch(input)
            {
                case 1:
                    this.currentGesture = this.gestures[0];
                    break;
                case 2:
                    this.currentGesture = this.gestures[1];
                    break;
                case 3:
                    this.currentGesture = this.gestures[2];
                    break;
                case 4:
                    this.currentGesture = this.gestures[3];
                    break;
                case 5:
                    this.currentGesture = this.gestures[4];
                    break;
            }
        }
    }
}
