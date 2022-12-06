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
