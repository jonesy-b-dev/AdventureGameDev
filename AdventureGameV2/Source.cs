﻿using AdventureGameV2.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameV2
{
    internal class Source
    {
        static void Main(string[] args)
        {
            bool gameRunning = true;

            Console.WriteLine("Welcome to The Forest!");
            Console.Write("Name your player: ");
            Player player1 = new Player(Console.ReadLine());

            Chest chest = new Chest();
            Inventory.inventory.Add(chest);

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
                    Console.ReadLine();
                }
            }

            Console.WriteLine("Thanks for playing!");

            Console.ReadLine();
        }
    }
}
