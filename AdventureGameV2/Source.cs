using AdventureGameV2.Items;
using System;

namespace AdventureGameV2
{
    internal class Source
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to The Forest!");
            Console.Write("Name your player: ");
            Player player1 = new Player(Console.ReadLine());

            Chest chest = new Chest();
            Inventory.inventory.Add(chest);

            Console.WriteLine("\nYou are in a wide forest and maybe you can find some stuff around here. Ff you dont know what to do you can always ask for help by typing \"help\" \n\nPress Enter to continue....");
            Console.ReadLine();

            InputHandler.SetPlayer(player1);

            //Start first game round
            InputHandler.GetInput();
        }
    }
}
