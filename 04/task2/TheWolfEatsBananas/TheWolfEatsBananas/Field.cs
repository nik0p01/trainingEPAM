using System;

namespace TheWolvesAndBananas
{
    public class Field
    {
        public Field(Vector2D size)
        {
            if (size.X < 0 || size.Y < 0)
            {
                throw new Exception("Item can not have negative value size");
            }
            Size = size;
        }
        public Vector2D Size { get; }
    }
}
