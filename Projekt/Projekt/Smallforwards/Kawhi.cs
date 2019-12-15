using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Kawhi : Player
    {
        public Kawhi()
        {
            height = 201;
            wingspan = 221;
            weight = 104;
            takeover = "Slashing";
            name = "Kawhi Leonard";
            Getstats();
        }
    }
}
