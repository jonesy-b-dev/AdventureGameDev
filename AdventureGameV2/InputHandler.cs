using Microsoft.Win32;
using System;
using System.Linq;

namespace AdventureGameV2
{
    internal class InputHandler
    {
        static string[] inputArr;
        static string input;
        static bool validInput;


        internal static bool getInput()
        {
            input = Console.ReadLine().ToLower();

            makeArray();

            if (indentifyFirstWord() && indentifySecondWord())
            {
                return true;
            }
            else return false;
        }


        private static void makeArray()
        {
            input = string.Join(" ", input.Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries));
            inputArr = input.Split(' ');
        }
        
        private static bool indentifyFirstWord()
        {
            switch (inputArr[0])
            {
                case "move":
                    Move();
                    return true;
                case "use":
                    Use();
                    return true;
                case "help":
                    EventHandler.Help();
                    return true;
                case "inventory":
                    Inventory.printItems();
                    return true;
                default:
                    return false;
            }
        }

        private static bool indentifySecondWord()
        {
            throw new NotImplementedException();
        }

        private static void Move()
        {
            throw new NotImplementedException();
        }

        private static void Use()
        {
            throw new NotImplementedException();
        }
    }
}