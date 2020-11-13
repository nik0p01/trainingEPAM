using System;

namespace TheWolvesAndBananas
{
    class Bear : Hunter
    {
        public Bear(Vector2D position, Vector2D sizeItem) : base(position, sizeItem) { }

        public override void Draw(IDrawVisitor drawVisitor)
        {
            drawVisitor.DrawForBear(this);
        }

        public override Vector2D Follow(Item item)
        {
            Random rnd = new Random();
            return new Vector2D(rnd.Next(-1, 1), rnd.Next(-1, 1));
        }
    }
}
