namespace AdventureGameV2.Items
{
    internal class Gold : ItemBase
    {
        public Gold()
        {
            _name = "Gold";
            _weight = rnd.Next(15, 30);
        }
    }
}
