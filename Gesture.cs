using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSApp
{
    internal abstract class Gesture
    {
        string name;

        public Gesture(string name)
        {
            this.name = name;
        }

        public abstract bool CompareGestures();
    }
}
