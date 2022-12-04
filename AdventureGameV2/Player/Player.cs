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
        public void MovePlayer(int inputX, int inputY)
        {
            Console.Write("You started to walk and your ");
            _location[0] += inputX;
            _location[1] += inputY;
            Console.WriteLine(PrintLocation());
            Console.WriteLine("Press enter to continue....");
            Console.ReadLine();
        }
        
        public string PrintLocation()
        {
            return "your position is now: Vertical: " + _location[0].ToString() + " Horizontal: " + _location[1].ToString();
        }
    }
}
