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
    }
}

