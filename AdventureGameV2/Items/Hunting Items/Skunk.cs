using AdventureGameV2.Items.Special_Items;
using System;

namespace AdventureGameV2.Items
{
    internal class Skunk : ItemBase
    {
        public Skunk()
        {
            _name = "Skunk";
            _weight = rnd.Next(1, 4);
        }

        public override void Use()
        {
            SkunkMeat skunkMeat = new SkunkMeat();
            Inventory.inventory.Add(skunkMeat);
            Console.WriteLine("You got skunk meat!");
            Console.WriteLine("Press enter to continue...");
        }
    }
}
