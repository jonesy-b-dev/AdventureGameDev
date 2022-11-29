using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameV2
{
    internal class ItemBase
    {
        private int _name;
        private int _weight;

        public ItemBase(int name, int weight)
        {
            _name = name;
            _weight = weight;   
        }

        protected void PrintDetails()
        {
            Console.WriteLine("Name: " + _name);
            Console.WriteLine("Weight: " + _weight);
        }
    }
}
