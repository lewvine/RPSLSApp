using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSApp
{
    public abstract class Gesture
    {
        public string name;

        public abstract int CompareGestures(Gesture gesture);
    }
}
