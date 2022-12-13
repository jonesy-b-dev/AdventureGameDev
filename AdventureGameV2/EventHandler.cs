using AdventureGameV2.Items.Item_Base;
using System;

namespace AdventureGameV2
{
    internal static class EventHandler
    {
        #region Action 2

        internal static bool ActionOption(Player player)
        {
            Console.WriteLine("What do you want to do at this location?");
            string input = Console.ReadLine().ToLower();

            
            return true;
        }

        internal static void Hunt(Player player)
        {
            ItemBase huntItem = ItemGenerator.newHuntItem();
            Console.WriteLine("You started hunting here and found a " + huntItem.GetName());
            Inventory.inventory.Add(huntItem);
        }

        internal static void Dig(Player player)
        {
            ItemBase digItem = ItemGenerator.newDigItem();
            Console.WriteLine("You started digging here and found a " + digItem.GetName());
            Inventory.inventory.Add(digItem);
        }
        #endregion

        #region Alway avalible commands

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
        }
        private static void ShowInventory()
        {
            Inventory.PrintItems();
        }
        #endregion
    }
}
