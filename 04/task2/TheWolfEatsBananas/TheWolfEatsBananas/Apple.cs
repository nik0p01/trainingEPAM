namespace TheWolvesAndBananas
{
    class Apple : Bonus
    {
        public Apple(Vector2D position, Vector2D sizeItem, int value) : base(position, sizeItem, value)
        {
        }

        public override void Draw(IDrawVisitor drawVisitor)
        {
            drawVisitor.DrawForApple(this);
        }
    }
}
