using AdventureGameV2;
using AdventureGameV2.Items;
using AdventureGameV2.Items.Item_Base;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameV2
{
    internal static class EventHandler
    {
        #region Action 1

        public static bool MoveOption(Player player)
        {
            Console.WriteLine("Where do you want to go?");
            string input = Console.ReadLine().ToLower();

            switch (input)
            {
                case "help":
                    Help1(player);
                    MoveOption(player);
                    break;
                case "move north":
                    player.MovePlayer(1,0);
                    break;
                case "move south":
                    player.MovePlayer(-1, 0);
                    break;
                case "move west":
                    player.MovePlayer(0,1);
                    break;
                case "move east":
                    player.MovePlayer(0, -1);
                    break;
                case "inventory":
                    ShowInventory();
                    MoveOption(player);
                    break;
                case "exit":
                    return false;
                default: Console.WriteLine("That is no valid input. Please try again or type help for a list of avalible commands.");
                    MoveOption(player);
                    break;
            }
            return true;
        }

        private static void Help1(Player player)
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
        #endregion

        #region Action 2

        internal static bool ActionOption(Player player)
        {
            Console.WriteLine("What do you want to do at this location?");
            string input = Console.ReadLine().ToLower();

            switch (input)
            {
                case "help":
                    Help2(player);
                    ActionOption(player);
                    break;
                case "dig":
                    dig(player);
                    break;
                case "hunt":
                    hunt(player);
                    break;
                case "nothing":
                    Console.WriteLine("You did nothing here.");
                    break;
                case "inventory":
                    ShowInventory();
                    ActionOption(player);
                    break;
                case "exit":
                    return false;
                default:
                    Console.WriteLine("That is no valid input. Please try again or type help for a list of avalible commands.");
                    ActionOption(player);
                    break;
            }
            Console.ReadLine();
            return true;
        }

        private static void hunt(Player player)
        {
            ItemBase huntItem = ItemGenerator.newHuntItem();
            Console.WriteLine("You started hunting here and found a " + huntItem.GetName());
            Inventory.inventory.Add(huntItem);
        }

        private static void dig(Player player)
        {
            ItemBase digItem = ItemGenerator.newDigItem();
            Console.WriteLine("You started digging here and found a " + digItem.GetName());
            Inventory.inventory.Add(digItem);
        }

        private static void Help2(Player player)
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
            ActionOption(player);
        }
        #endregion

        #region Alway avalible commands

        private static void ShowInventory()
        {
            Inventory.printItems();
        }
        #endregion
    }
}
