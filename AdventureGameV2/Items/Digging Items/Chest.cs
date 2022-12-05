using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    Inventory.inventory.Add(iron);
                    break;
                case 1:
                    Console.WriteLine("You found a gold bar!");
                    Gold gold = new Gold();
                    Inventory.inventory.Add(gold);
                    break;
                default:
                    throw new Exception("Invalid number generated in random");
            }
        }
    }
}

