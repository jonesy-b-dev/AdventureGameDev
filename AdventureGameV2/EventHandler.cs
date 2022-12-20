using AdventureGameV2.Items;
using System;

namespace AdventureGameV2
{
    internal static class EventHandler
    {

        internal static void Hunt()
        {
            ItemBase huntItem = ItemGenerator.NewHuntItem();
            Console.WriteLine("You started hunting here and found a " + huntItem.GetName());
            Inventory.AddToInventory(huntItem, huntItem.GetName());
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

        }

        internal static void Dig()
        {
            ItemBase digItem = ItemGenerator.NewDigItem();
            Console.WriteLine("You started digging here and found a " + digItem.GetName());
            Inventory.AddToInventory(digItem, digItem.GetName());
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

        }

        internal static void Help()
        {
            Console.WriteLine("List of action:" +
                "\nHelp" +
                "\n*Movement*" +
                "\nMove North" +
                "\nMove South" +
                "\nMove East" +
                "\nMove West" +
                "\n*Actions*" +
                "\nHunt" +
                "\nDig" +
                "\nNothing" +
                "\nExit" +
                "\n");


            Console.ReadLine();
        }
    }
}
