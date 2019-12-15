using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class PointGuard : Player
    {

        public void KyrieErving()
        {
            height = 188;
            wingspan = 193;
            weight = 88;
            takeover = "Playmaking";
            name = "Kyrie Erving";
            Getstats();
        }

        public void RusselWestbrook()
        {
            height = 191;
            wingspan = 203;
            weight = 91;
            takeover = "Slashing";
            name = "Russel Westbrook";
            Getstats();
        }

        public void DamianLillard()
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
