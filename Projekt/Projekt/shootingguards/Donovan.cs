using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Donovan : Player
    {
        public Donovan()
        {
            height = 185;
            wingspan = 208;
            weight = 98;
            takeover = "Slashing";
            name = "Donovan Mitchell";
            Getstats();
        }
    }
}
