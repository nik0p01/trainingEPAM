namespace TheWolvesAndBananas
{
    public abstract class Hunter : MovableItem
    {
        public Hunter(Vector2D position, Vector2D sizeItem) : base(position, sizeItem) { }

        public abstract Vector2D Follow(Item item);


    }
}
