using System;

namespace AdventureGameV2.Items.Item_Base
{
    internal static class ItemGenerator
    {
        public static ItemBase NewHuntItem()
        {
            Random rnd = new Random();
            int randomNum = rnd.Next(0, 2);

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

        public static ItemBase NewDigItem()
        {
            Random rnd = new Random();
            int randomNum = rnd.Next(0, 2);

            switch (randomNum)
            {
                case 0:
                    Chest chest = new Chest();
                    return chest;
                case 1:
                    Stone stone = new Stone();
                    return stone;
                default:
                    return null;
            }
        }
    }
}
