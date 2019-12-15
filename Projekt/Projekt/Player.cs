using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Player
    {
        //De olika värdena alla spelare kommer ha
        public int height;
        public int weight;
        public int wingspan;
        public string takeover;
        public string name;

        public void Getstats()//En metod som printar ut spelarens stats 
        {
            Console.WriteLine("Height: " + height);
            Console.WriteLine("Weight: " + weight);
            Console.WriteLine("Wingpsan:" + wingspan);
            Console.WriteLine("Takeover: " + takeover);
            Console.WriteLine("Name: " + name);
        }



        // Lebron
        // Curry
        // Kawhi
        // PG
        // Giannis









    }
}
