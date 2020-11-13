namespace TheWolvesAndBananas
{
    class Cherry : Bonus
    {
        public Cherry(Vector2D position, Vector2D sizeItem, int value) : base(position, sizeItem, value)
        {
        }

        public override void Draw(IDrawVisitor drawVisitor)
        {
            drawVisitor.DrawForCherry(this);
        }
    }
}
