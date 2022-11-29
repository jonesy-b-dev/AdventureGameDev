using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameV2.Items.Item_Base
{
    internal static class ItemGenerator
    {
        public static ItemBase newHuntItem() 
        {
            Random rnd = new Random();
            int randomNum = rnd.Next(0, 3);

            switch (randomNum)
            {
                case 0:
                    Deer deer = new Deer();
                    return deer;
                case 1:
                    Skunk skunk = new Skunk();
                    return skunk;
                default:
                    return null;
            }
        }
    }
}
