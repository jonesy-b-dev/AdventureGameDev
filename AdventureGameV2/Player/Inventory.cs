using System;
using System.Collections.Generic;

namespace AdventureGameV2
{
    internal static class Inventory
    {
        public static List<ItemBase> inventory = new List<ItemBase> { };

        public static void PrintItems()
        {
            Console.WriteLine("\nCurrent items in your inventory:");
            foreach (ItemBase item in inventory)
            {
                item.PrintDetails();
                Console.WriteLine();
            }
            Console.Write("Press enter to continue...");
            Console.ReadKey();
        }

        internal static void CheckIfItemIsInInventory(ItemBase itimToSearch)
        {
            throw new NotImplementedException();
        }
    }

}
