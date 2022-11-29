using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameV2.Items
{
    internal class Stone : ItemBase
    {
        public Stone()
        {
            _name = "Stone";
            _weight = rnd.Next(1, 20);
        }
    }
}

