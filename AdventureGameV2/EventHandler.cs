using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    internal static class EventHandler
    {
        #region Action 1

        public static bool ActionOne(Player player)
        {
            Console.WriteLine("Where do you want to go?");
            string input = Console.ReadLine().ToLower();

            switch (input)
            {
                case "help":
                    Help();
                    break;
                case "move north":
                    MoveNorth(player);
                    break;
                case "move south":
                    MoveSouth(player);
                    break;
                case "move west":
                    MoveWest(player);
                    break;
                case "move east":
                    MoveEast(player);
                    break;
                case "exit":
                    return false;
                default: Console.WriteLine("That is no valid input. Please try again or type help for a list of avalible commands.");
                    Console.ReadLine();
                    ActionOne(player);
                    break;
            }

            if (input != "help")
            {
                Console.WriteLine(player.PrintLocation());
            }


            Console.ReadLine();
            return true;
        }


        private static void Help()
        {
            Console.WriteLine("List of action:" +
                "\nHelp" +
                "\n*Movement*" +
                "\nMove North" +
                "\nMove South" +
                "\nMove East" +
                "\nMove West" +
                "");
        }

        private static void MoveNorth(Player player)
        {
            player.MoveUpDown(1);
        }
        private static void MoveSouth(Player player)
        {
            player.MoveUpDown(-1);
        }
        private static void MoveWest(Player player)
        {
            player.MoveSideWays(1);
        }

        private static void MoveEast(Player player)
        {
            player.MoveSideWays(-1);
        }
        #endregion


        internal static bool ActionTwo(Player player)
        {
            Console.WriteLine(player.PrintLocation());
            Console.WriteLine("What do you want to do at this location?");
            string input = Console.ReadLine().ToLower();

            switch (input)
            {
                case "help":
                    Help();
                    break;
                case "dig":
                    dig(player);
                    break;
                case "hunt":
                    hunt(player);
                    break;
                case "nothing":
                    Console.WriteLine("You did nothing here.");
                    return false;
                case "exit":
                    return false;
                default:
                    Console.WriteLine("That is no valid input. Please try again or type help for a list of avalible commands.");
                    Console.ReadLine();
                    ActionOne(player);
                    break;
            }
            Console.ReadLine();
            return true;
        }

        private static void hunt(Player player)
        {
            Console.WriteLine("You started hunting here and found a ");
        }

        private static void dig(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
