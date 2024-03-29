﻿using System;

namespace AdventureGameV2
{
    //This class askes for input and calls the appropiate functions for it
    internal class InputHandler
    {
        static string[] _inputArr;
        static string _input;
        static Player _player;

        internal static void SetPlayer(Player player1)
        {
            _player = player1;
        }

        internal static void GetInput()
        {
            Console.Clear();
            Console.WriteLine("What do you want to do");

            _input = Console.ReadLine().ToLower();

            MakeArray();

            //Fuction indentifies the first word and calls functions to indentify and handle the possible second word
            IndentifyFirstWord();
            GetInput();

        }

        private static void MakeArray()
        {
            _input = string.Join(" ", _input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            _inputArr = _input.Split(' ');
        }

        private static void IndentifyFirstWord()
        {
            switch (_inputArr[0])
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
                    if (!_player._exploredLocations.Contains(_player._location))
                    {
                        EventHandler.Dig();
                        _player.AddExploredLocation();
                    }
                    else
                    {
                        Console.WriteLine("You have already explored this location. You can only dig once per location.");
                        Console.ReadLine();
                    }
                    break;
                case "hunt":
                    EventHandler.Hunt();
                    _player.AddExploredLocation();
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
            switch (_inputArr[1])
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
            switch (_inputArr[1])
            {
                case "chest":

                    foreach (ItemBase item in Inventory.inventory)
                    {
                        if (item.GetName() == "Chest")
                        {
                            item.Use();

                            Console.ReadLine();

                            Inventory.inventory.Remove(item);
                            return;
                        }
                    }
                    Console.WriteLine("You dont have a chest.");
                    break;

                case "skunk":

                    foreach (ItemBase item in Inventory.inventory)
                    {
                        if (item.GetName() == "Skunk")
                        {
                            item.Use();

                            Console.ReadLine();

                            Inventory.inventory.Remove(item);
                            return;
                        }
                    }
                    Console.WriteLine("You dont have a skunk.");
                    break;
                default:
                    Console.WriteLine("You cant use that item.");
                    break;
            }
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

        }

    }
}