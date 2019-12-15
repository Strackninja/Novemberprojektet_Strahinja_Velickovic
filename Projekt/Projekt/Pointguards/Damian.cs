using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Damian : Player
    {
        public Damian()
        {
            height = 191;
            wingspan = 203;
            weight = 88;
            takeover = "Shooting";
            name = "Damian Lillard";
            Getstats();
        }
    }
}
