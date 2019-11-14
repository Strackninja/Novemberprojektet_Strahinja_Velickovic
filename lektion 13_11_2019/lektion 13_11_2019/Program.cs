using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lektion_13_11_2019
{
    class Program
    {
        static void Main(string[] args)
        {

            spaceship SPACESHIP = new spaceship();
            Freighter nostromo = new Freighter();

            spaceship ship = new Freighter();

            SPACESHIP.Attack();
            nostromo.Attack();
            ship.Attack();

            Console.ReadLine();

        }
    }
}
