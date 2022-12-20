using System;

namespace AdventureGameV2.Items
{
    internal class Chest : ItemBase
    {
        public Chest()
        {
            _name = "Chest";
            _weight = rnd.Next(10, 15);
        }

        public override void Use()
        {
            int randomNum = rnd.Next(0, 2);

            switch (randomNum)
            {
                case 0:
                    Console.WriteLine("You found a iron bar!");
                    Iron iron = new Iron();
                    Inventory.AddToInventory(iron, iron.GetName());
                    break;
                case 1:
                    Console.WriteLine("You found a gold bar!");
                    Gold gold = new Gold();
                    Inventory.AddToInventory(gold, gold.GetName());
                    break;
                default:
                    throw new Exception("Invalid number generated in random");
            }
            Console.WriteLine("Press enter to continue...");
        }
    }
}

