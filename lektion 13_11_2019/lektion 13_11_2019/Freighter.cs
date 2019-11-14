using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lektion_13_11_2019
{
    class Freighter : spaceship
    {
        public Freighter()
        {
            speed = 2;
        }

        public override void Attack()
        {
            Console.WriteLine("no attack");
        }

    }
}
