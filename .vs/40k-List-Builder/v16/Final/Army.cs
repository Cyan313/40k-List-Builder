using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Army
    {
        public string name;
        internal int detachment;
        internal int Points = 0;
        internal int PL = 0;
        internal int CP = 0;
        public int Maxpoints;
    }

    class Imperium : Army
    {
        internal int Faction;
    }

    class Chaos : Army
    {
        internal int Faction;
    }

    class Xenos : Army
    {
        internal int Faction;
    }
}
