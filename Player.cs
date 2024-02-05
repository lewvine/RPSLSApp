using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSApp
{
    internal abstract class Player
    {
        public string name;
        public Gesture currentGesture;
        public List<Gesture> gestures;
        //Needs to implement a choose gestue method.
        //Needs to have a list of possible gestures.
        public Player()
        {
            this.currentGesture = null;
            this.gestures = new List<Gesture>();
            Lizard lizard = new Lizard();
            Rock rock = new Rock();
            Paper paper = new Paper();
            Scissors scissors = new Scissors();
            Spock spock = new Spock();
            gestures.Add(rock);
            gestures.Add(paper);
            gestures.Add(scissors);
            gestures.Add(lizard);
            gestures.Add(spock);
        }
        public abstract void SetCurrentGesture();
    }
}
