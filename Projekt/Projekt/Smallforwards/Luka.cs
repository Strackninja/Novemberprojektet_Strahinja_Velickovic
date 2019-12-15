using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Luka : Player
    {
        public Luka()
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
