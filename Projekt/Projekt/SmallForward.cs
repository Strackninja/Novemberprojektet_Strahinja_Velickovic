using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class SmallForward : Player
    {

        public void LebronJames()
        {
            height = 203;
            wingspan = 214;
            weight = 113;
            takeover = "Playmaking";
            name = "Lebron James";
            Getstats();
        }

        public void KawhiLeonard()
        {
            height = 201;
            wingspan = 221;
            weight = 104;
            takeover = "Slashing";
            name = "Kawhi Leonard";
            Getstats();
        }

        public void LukaDoncic()
        {
            height = 201;
            wingspan = 208;
            weight = 208;
            takeover = "Shooting";
            name = "Luka Doncic";
            Getstats();
        }

    }
}
