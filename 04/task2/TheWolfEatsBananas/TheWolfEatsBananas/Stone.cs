namespace TheWolvesAndBananas
{
    class Stone : Obstacle
    {
        public Stone(Vector2D position, Vector2D sizeItem) : base(position, sizeItem) { }

        public override void Draw(IDrawVisitor drawVisitor)
        {
            drawVisitor.DrawForStone(this);
        }
    }
}
