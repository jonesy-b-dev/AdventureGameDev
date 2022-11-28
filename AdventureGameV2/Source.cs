using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    internal class Source
    {
        static void Main(string[] args)
        {
            bool gameRunning = true;

            Console.WriteLine("Welcome to The Forrest!");
            Task.Delay(1000).Wait();
            Console.Write("Name your player: ");
            Player player1 = new Player(Console.ReadLine());

            Console.WriteLine("You are in a wide forrest and maybe you can find some stuff around here. if you dont know what to do you can always ask for help \nPress Enter to continue....");
            Console.ReadLine();

            while (gameRunning)
            {
                gameRunning = EventHandler.ActionOne(player1);
                if (gameRunning)
                {
                    EventHandler.ActionTwo(player1);
                }
            }

            Console.WriteLine("Thanks for playing!");

            Console.ReadLine();
        }
    }
}
