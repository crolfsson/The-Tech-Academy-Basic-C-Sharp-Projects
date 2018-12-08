using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    //interface naming conventions always start with a capital I
    //everything is publicin an interface, you don't need to identify it
    interface IWalkAway
    {
        void WalkAway(Player player);
    }
}

