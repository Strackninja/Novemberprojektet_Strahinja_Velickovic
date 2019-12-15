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
           // Player cpg = new PointGuard();
           // Player csg = new ShootingGuard();
            //Player csf = new SmallForward();

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
            //Sätter en delay på texten
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
            //Rensar konsolen
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
            Console.WriteLine("Please enter a number between 1-3 to choose a player!");
            int pointanswer = Answers();

            //Det första valet spelaren gör, spelaren väljer 1 pointguard utav 3 genom att skriva en siffra mellan 1-3
            if (pointanswer == 1)
            {
                pg = new Kyrie();
            }
            else if(pointanswer == 2)
            {
                pg = new Russel();
            }
            else if(pointanswer == 3)
            {
                pg = new Damian();
            }
            Console.Clear();
            Console.WriteLine("Great job!");
            Thread.Sleep(600);
            Console.WriteLine("These are your players stats: ");
            Thread.Sleep(600);
            //Kallar på metoden i Player som printar ut statsen för spelaren
            pg.Getstats();
            Console.ReadLine();
            Console.Clear();


            Console.WriteLine("It is time to choose a ShootinGguard");
            Thread.Sleep(600);
            Console.WriteLine("The ShootingGuards you can choose from are");
            Thread.Sleep(600);
            Console.WriteLine("James Harden");
            Thread.Sleep(600);
            Console.WriteLine("Donovan Mitchell");
            Thread.Sleep(600);
            Console.WriteLine("Devin Booker");
            Thread.Sleep(600);
            Console.WriteLine("Now its time for you to choose a player");
            Thread.Sleep(600);
            Console.WriteLine("Please enter a number between 1-3 to choose a player!");
            int shootinganswer = Answers();
            //Samma sak som för pointguard men för shootingguard
            if (shootinganswer == 1)
            {
                sg = new James();
            }
            else if (shootinganswer == 2)
            {
                sg = new Donovan();
            }
            else if (shootinganswer == 3)
            {
                sg = new Devin();
            }
            Console.Clear();
            Console.WriteLine("Great job!");
            Thread.Sleep(600);
            Console.WriteLine("These are your players stats: ");
            Thread.Sleep(600);
            sg.Getstats();
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("And finally, time to choose a SmallForward");
            Thread.Sleep(600);
            Console.WriteLine("The SmallForwards you can choose from are");
            Thread.Sleep(600);
            Console.WriteLine("Lebron James");
            Thread.Sleep(600);
            Console.WriteLine("Kawhi Leonard");
            Thread.Sleep(600);
            Console.WriteLine("Luka Doncic");
            Thread.Sleep(600);
            Console.WriteLine("Now its time for you to choose a player");
            Thread.Sleep(600);
            Console.WriteLine("Please enter a number between 1-3 to choose a player!");
            int smallanswer = Answers();
            //samma sak som för pointguard men för SmallForward
            if (smallanswer == 1)
            {
                sf = new Lebron();
            }
            else if (smallanswer == 2)
            {
                sf = new Kawhi();
            }
            else if (smallanswer == 3)
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
            Console.Clear();

            Console.WriteLine("This is your final team:");
            Thread.Sleep(600);
            Console.WriteLine(pg.name);//Printar ut pointguardens namn
            Thread.Sleep(600);
            Console.WriteLine(sg.name);//Printar ut shootingguardens namn
            Thread.Sleep(600);
            Console.WriteLine(sf.name);//Printar ut smallforwardens namn

            Console.ReadLine();
        }
        // En metod som kontrollerar ifall spelaren väljer en siffra mellan 1-3
        // Ifall spelaren väljer en siffra som inte är mellan 1-3 kommer spelet att fråga om ett svar igen
        static int Answers() 
        {
            int playerchoice = 0;//Det värde som kommer att användas i val av spelare
            string playeranswer = Console.ReadLine();//Spelarens input
            int.TryParse(playeranswer, out playerchoice);//Konverterar spelarens string input till en int
            bool correct = int.TryParse(playeranswer, out playerchoice);//Ser till att konverteringen blev korrekt

            while (correct == false || playerchoice != 1 && playerchoice != 2 && playerchoice != 3)
            {
                Console.WriteLine("Please enter a number between 1-3");

                playerchoice = 0;
                playeranswer = Console.ReadLine();
                correct = int.TryParse(playeranswer, out playerchoice);
            } 

            if (playerchoice == 1)//Ifall spelaren klickar 1 kommer spelet returnera värdet 1 och välja den första spelaren
            {
                return 1;
            }
            else if (playerchoice == 2)// Samma sak fast för 2
            {
                return 2;
            }
            else if (playerchoice == 3)//Samma sak fast för 3
            {
                return 3;
            }

            return 0;

        }

            




    }
}
