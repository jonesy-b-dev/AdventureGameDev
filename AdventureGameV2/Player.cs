using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    internal class Player
    {
        private int[] _location = new int[2] { 5, 6 };
        public string _name;

        public Player(string name)
        {
            _name = name;
        }

        //Movement
        public void MoveUpDown(int input)
        {
            _location[0] += input;
        }
        public void MoveSideWays(int input)
        {
            _location[1] += input;
        }

        public string PrintLocation()
        {
            return "Your Position: Vertical: " + _location[0].ToString() + " Horizontal: " + _location[1].ToString();
        }
    }
}
