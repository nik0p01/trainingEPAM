using System;

namespace TheWolvesAndBananas
{
    public abstract class Item
    {
        public Item(Vector2D position, Vector2D sizeItem)
        {
            if (position.X < 0 || position.Y < 0)
            {
                throw new Exception("Item can not have negative value position");
            }
            if (sizeItem.X < 0 || sizeItem.Y < 0)
            {
                throw new Exception("Item can not have negative value size");
            }
            position = position;
            Size = sizeItem;
        }
        public Vector2D position { get; protected set; }
        public Vector2D Size { get; protected set; }

        public abstract void Draw(IDrawVisitor drawVisitor);
    }
}
