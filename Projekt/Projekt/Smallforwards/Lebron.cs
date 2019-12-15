using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Lebron : Player
    {
        public Lebron()
        {
            height = 203;
            wingspan = 214;
            weight = 113;
            takeover = "Playmaking";
            name = "Lebron James";
            Getstats();
        }
    }
}
