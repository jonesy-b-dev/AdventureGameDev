﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameV2.Items
{
    internal class Deer : ItemBase
    {
        public Deer()
        {
            _name = "Deer";
            _weight = rnd.Next(40, 76);
        }
    }
}
