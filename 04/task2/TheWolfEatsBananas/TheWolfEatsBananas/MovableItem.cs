namespace TheWolvesAndBananas
{
    public abstract class MovableItem : Item
    {
        public MovableItem(Vector2D position, Vector2D sizeItem) : base(position, sizeItem)
        { }
        public Vector2D Move(Vector2D vector)
        {
            return this.position += vector;
        }


        public bool Collision(Item item)
        {
            if (this.position.X > (item.position.X + item.Size.X) || (this.position.X + this.Size.X) < item.position.X)
            {
                return false;
            }
            if (this.position.Y > (item.position.Y + item.Size.Y) || (this.position.Y + this.Size.Y) < item.position.Y)
            {
                return false;
            }
            return true;
        }

        public bool Collision(Field fill)
        {
            if ((this.position.X + this.Size.X < fill.Size.X) && (this.position.Y + this.Size.Y < fill.Size.Y) && this.position.X > 0 && this.position.Y > 0)
            {
                return false;
            }
            return false;
        }
    }
}
