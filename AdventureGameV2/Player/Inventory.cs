using System;
using System.Collections.Generic;

namespace AdventureGameV2
{
    internal static class Inventory
    {
        public static List<ItemBase> inventory = new List<ItemBase> { };
        public static List<string> strgInventory = new List<string> { };

        public static void PrintItems()
        {
            Console.WriteLine("\nCurrent items in your inventory:\n");
            foreach (ItemBase item in inventory)
            {
                item.PrintDetails();
                Console.WriteLine();    
            }
            Console.Write("Press enter to continue...");
            Console.ReadKey();
        }

        public static void AddToInventory(ItemBase item, string name)
        {
            inventory.Add(item);
            strgInventory.Add(name);
        }
    }

}
