using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSApp
{
    internal abstract class Player
    {
        public Gesture selectedGesture;
        public List<Gesture> gestures;
        //Needs to implement a choose gestue method.
        //Needs to have a list of possible gestures.
        public Player()
        {
            this.selectedGesture = null;
            this.gestures = new List<Gesture>() { ""}
        }
        public abstract Gesture ChooseGesture();
    }
}
