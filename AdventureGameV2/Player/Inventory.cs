using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameV2
{
    internal static class Inventory
    {
        public static List<ItemBase> inventory = new List<ItemBase> { };

        public static void printItems()
        {
            Console.WriteLine("\n Current items in your inventory:");
            foreach (ItemBase item in inventory)
            {
                item.PrintDetails();
                Console.WriteLine();
            }
        }
    }

}
