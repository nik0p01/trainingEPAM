namespace TheWolvesAndBananas
{
    class Tree : Obstacle
    {
        public Tree(Vector2D position, Vector2D sizeItem) : base(position, sizeItem) { }

        public override void Draw(IDrawVisitor drawVisitor)
        {
            drawVisitor.DrawForTree(this);
        }
    }
}
