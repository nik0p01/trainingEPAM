namespace TheWolvesAndBananas
{
    abstract class Bonus : Item
    {
        public Bonus(Vector2D position, Vector2D sizeItem, int value) : base(position, sizeItem)
        {
            Value = value;
        }
        public int Value { get; }
    }
}
