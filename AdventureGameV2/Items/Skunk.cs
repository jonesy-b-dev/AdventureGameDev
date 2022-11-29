using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AdventureGameV2.Items
{
    internal class Skunk : ItemBase
    {
        public Skunk()
        {
            _name = "Skunk";
            _weight = rnd.Next(1, 4);
        }
    }
}
