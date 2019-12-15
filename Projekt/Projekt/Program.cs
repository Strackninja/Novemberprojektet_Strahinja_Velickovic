using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Spelarens spelare
            Player pg = new PointGuard();
            Player sg = new ShootingGuard();
            Player sf = new SmallForward();
            //Datorns spelare
            Player cpg = new PointGuard();
            Player csg = new ShootingGuard();
            Player csf = new SmallForward();

            // idé till spel
            // Du ska skapa din egna basketspelare likt Myplayer funktionen i alla NBA2K spel. 
            // Du ska välja olika atributer till din karaktär, alltså t.ex Position , Length , Weight , Wingspan och 
            // För Position ska du kunna välja mellan PointGuard, Shooting Guard, Small Forward, Power Forward och Center
            // För Lenght ska du kunna välja mellan att vara 5'7-7'4
            // För Weight ska du kunna välja mellan 175lb-280lb
            // För Wingspan ska spelaren kunna välja mellan 76"- 87"
            // För Takeover ska man kunna välja mellan Slasher, playmaker, spot up shooter, 

            //FINAL IDEA OCH DET JAG SKA KÖRA PÅ!!!!!!!!!!!!!!!
            // Du ska skapa ett basket lag av ´3 personer som kör olika positioner, Pointguard, Shootingguard och Smallforward
            // Du skapar laget genom att välja redan existerande spelare med olika stats.
            // Spelet kommer sedan skapa ett randomiserat lag med olika stats.
            // Sedan ska spelet skapa ett mellanvärde av alla stats och utse en vinnare med hjälp av det

            Console.WriteLine("MAKE YOUR OWN 3");
            Thread.Sleep(600);
            Console.WriteLine("PRESS ENTER TO CONTINUE");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You are creating your own squad made up of three teammates");
            Thread.Sleep(600);
            Console.WriteLine("The team is going to consist of a PointGuard, a ShootingGuard and a SmallForward");
            Thread.Sleep(600);
            Console.WriteLine("You are to choose between three players in every role and create your squad");
            Thread.Sleep(600);
            Console.WriteLine("PRESS ENTER TO CONTINUE");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("The first thing you are going to do is choose a PointGuard");
            Thread.Sleep(600);
            Console.WriteLine("The PointGuards you can choose from are");
            Thread.Sleep(600);
            Console.WriteLine("Kyrie Erving");
            Thread.Sleep(600);
            Console.WriteLine("Russel Westbrook");
            Thread.Sleep(600);
            Console.WriteLine("Damian Lillard");
            Thread.Sleep(600);
            Console.WriteLine("Now its time for you to choose a player");
            Console.WriteLine("Please write the first name of the pointguard that you want to select!");
            string pointanswer = Console.ReadLine(); ;

            if (pointanswer == "Kyrie")
            {
                pg = new Kyrie();
            }
            else if(pointanswer == "Russel")
            {
                pg = new Russel();
            }
            else if(pointanswer == "Damian")
            {
                pg = new Damian();
            }
            Console.Clear();
            Console.WriteLine("Great job!");
            Thread.Sleep(600);
            Console.WriteLine("These are your players stats: ");
            Thread.Sleep(600);
            pg.Getstats();


            Console.WriteLine("It is time to choose a ShootinGguard");
            string shootinganswer = Console.ReadLine();

            if (shootinganswer == "James")
            {
                sg = new James();
            }
            else if (shootinganswer == "Donovan")
            {
                sg = new Donovan();
            }
            else if (shootinganswer == "Devin")
            {
                sg = new Devin();
            }
            Console.Clear();
            Console.WriteLine("Great job!");
            Thread.Sleep(600);
            Console.WriteLine("These are your players stats: ");
            Thread.Sleep(600);
            sg.Getstats();

            Console.WriteLine("And finally, time to choose a SmallForward");
            string smallanswer = Console.ReadLine();

            if (smallanswer == "Lebron")
            {
                sf = new Lebron();
            }
            else if (smallanswer == "Kawhi")
            {
                sf = new Kawhi();
            }
            else if (smallanswer == "Luka")
            {
                sf = new Luka();
            }
            Console.Clear();
            Console.WriteLine("Great job!");
            Thread.Sleep(600);
            Console.WriteLine("These are your players stats: ");
            Thread.Sleep(600);
            sf.Getstats();

            Console.ReadLine();
        }

        static int Answers()
        {
            int playerchoice = 0;
            string playeranswer = Console.ReadLine();
            int.TryParse(playeranswer, out playerchoice);
            bool correct = int.TryParse(playeranswer, out playerchoice);

            while (correct == false || playerchoice != 1 && playerchoice != 2 && playerchoice != 3)
            {
                Console.WriteLine("Please enter a number between 1-3");

                playerchoice = 0;
                playeranswer = Console.ReadLine();
                correct = int.TryParse(playeranswer, out playerchoice);
            } 

            if (playerchoice == 1)
            {
                return 1;
            }
            else if (playerchoice == 2)
            {
                return 2;
            }
            else if (playerchoice == 3)
            {
                return 3;
            }

            return 0;

        }

            




    }
}
