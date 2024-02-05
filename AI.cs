using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSApp
{
    internal class AI : Player
    {
        public AI() : base()
        {
            this.name = "Computer #1";
        }

        public override void SetCurrentGesture()
        {
            bool validInput = false;
            Random rand = new Random();
            int input = rand.Next(1,5);
            this.currentGesture = this.gestures[input - 1];
        }
    }
}
