using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lektion_13_11_2019
{
    class spaceship
    {

        public int speed;

        public spaceship()
        {
            speed = 10;
        }

        public virtual void Attack()
        {
            Console.WriteLine("attack");
        }

    }
}
