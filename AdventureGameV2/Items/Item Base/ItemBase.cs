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
        //Random to generate properties of items
        protected Random rnd = new Random();

        protected string _name;
        protected int _weight;

        public void PrintDetails()
        {
            Console.WriteLine("Name: " + _name);
            Console.WriteLine("Weight: " + _weight);
        }

        public string GetName()
        {
            return _name;
        }

        public virtual void Use() { }
    }
}
