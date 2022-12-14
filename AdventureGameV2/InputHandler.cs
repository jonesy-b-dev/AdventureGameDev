using Microsoft.Win32;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace AdventureGameV2
{
    //This class askes for input and calls the appropiate functions for it
    internal class InputHandler
    {
        static string[] inputArr;
        static string input;
        static Player _player;

        internal static void SetPlayer(Player player1)
        {
            _player = player1;
        }

        internal static void GetInput()
        {
            Console.Clear();
            Console.WriteLine("What do you want to do");

            input = Console.ReadLine().ToLower();

            MakeArray();

            //Fuction indentifies the first word and calls functions to indentify and handle the possible second word
            IndentifyFirstWord();
            GetInput();
            
        }

        private static void MakeArray()
        {
            input = string.Join(" ", input.Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries));
            inputArr = input.Split(' ');
        }
        
        private static void IndentifyFirstWord()
        {
            switch (inputArr[0])
            {
                case "move":
                    Move();
                    break;
                case "use":
                    Use();
                    break;
                case "help":
                    EventHandler.Help();
                    break;
                case "dig":
                    EventHandler.Dig();
                    break;
                case "hunt":
                    EventHandler.Hunt();
                    break;
                case "inventory":
                    Inventory.PrintItems();
                    break;
                case "exit":
                    Console.WriteLine("Thanks for playing!");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("That is no valid input. Please try again or type help for a list of avalible commands.");
                    Console.ReadLine();
                    break;
            }
        }

        private static void Move()
        {

            //We know its a move action now so all move actions are here
            switch (inputArr[1])
            {
                case "north":
                    _player.MovePlayer(1, 0);
                    break;
                case "south":
                    _player.MovePlayer(-1, 0);
                    break;
                case "west":
                    _player.MovePlayer(0, -1);
                    break;
                case "east":
                    _player.MovePlayer(0, 1);
                    break;
                default:
                    Console.WriteLine("That is no valid input. Please try again or type help for a list of avalible commands.");
                    Console.Write("Press enter to continue...");
                    Console.ReadLine();
                    break;
            }
        }

        private static void Use()
        {
            switch (inputArr[1])
            {
                case "chest":
                    if (Inventory.inventory.Contains(Chest)
                    {
            
                    }
                default:
                    break;
            }
        }

    }
}