namespace TheWolvesAndBananas
{
    class Banana : Bonus
    {
        public Banana(Vector2D position, Vector2D sizeItem, int value) : base(position, sizeItem, value)
        {
        }

        public override void Draw(IDrawVisitor drawVisitor)
        {
            drawVisitor.DrawForBanana(this);
        }
    }
}
