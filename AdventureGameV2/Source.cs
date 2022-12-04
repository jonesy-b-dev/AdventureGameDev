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

            Console.WriteLine("Welcome to The Forest!");
            Task.Delay(1000).Wait();
            Console.Write("Name your player: ");
            Player player1 = new Player(Console.ReadLine());

            Console.WriteLine("\nYou are in a wide forest and maybe you can find some stuff around here. Ff you dont know what to do you can always ask for help by typing \"help\" \n\nPress Enter to continue....");
            Console.ReadLine();

            //Main game loop
            while (gameRunning)
            {
                Console.Clear();
                gameRunning = EventHandler.MoveOption(player1);
                if (gameRunning)
                {
                    gameRunning = EventHandler.ActionOption(player1);
                }
            }

            Console.WriteLine("Thanks for playing!");

            Console.ReadLine();
        }
    }
}
