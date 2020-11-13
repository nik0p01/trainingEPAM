using System;

namespace TheWolvesAndBananas
{
    class Wolf : Hunter
    {
        public Wolf(Vector2D position, Vector2D sizeItem) : base(position, sizeItem) { }

        public override void Draw(IDrawVisitor drawVisitor)
        {
            drawVisitor.DrawForWolf(this);
        }

        public override Vector2D Follow(Item item)
        {
            var result = item.position - position;
            return new Vector2D(result.X != 0 ? result.X / Math.Abs(result.X) : 0, result.Y != 0 ? result.Y / Math.Abs(result.Y) : 0);
        }
    }
}
