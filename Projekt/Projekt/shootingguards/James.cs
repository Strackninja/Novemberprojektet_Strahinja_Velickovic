using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class James : Player
    {
        public James()
        {
            height = 196;
            wingspan = 210;
            weight = 100;
            takeover = "Shooting";
            name = "James Harden";
            Getstats();
        }
    }
}
