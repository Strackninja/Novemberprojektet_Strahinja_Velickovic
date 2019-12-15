using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Kyrie : Player
    {
        public Kyrie()
        {
            height = 188;
            wingspan = 193;
            weight = 88;
            takeover = "Playmaking";
            name = "Kyrie Erving";
            Getstats();
        }
    }
}
