using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class ShootingGuard : Player
    {

        public void JamesHarden()
        {
            height = 196;
            wingspan = 210;
            weight = 100;
            takeover = "Shooting";
            name = "James Harden";
            Getstats();
        }

        public void DonovanMitchell()
        {
            height = 185;
            wingspan = 208;
            weight = 98;
            takeover = "Slashing";
            name = "Donovan Mitchell";
            Getstats();
        }

        public void DevinBooker()
        {
            height = 196;
            wingspan = 204;
            weight = 95;
            takeover = "Playmaking";
            name = "Devin Booker";
            Getstats();
        }








    }
}
