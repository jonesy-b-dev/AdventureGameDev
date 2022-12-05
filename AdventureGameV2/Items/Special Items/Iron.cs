using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AdventureGameV2.Items
{
    internal class Iron : ItemBase
    {
        public Iron()
        {
            _name = "Iron";
            _weight = rnd.Next(15, 30);
        }
    }
}
