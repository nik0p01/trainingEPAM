namespace TheWolvesAndBananas
{
    class Player : MovableItem
    {
        public Player(Vector2D position, Vector2D sizeItem, int life) : base(position, sizeItem)
        {
            Life = life;
        }
        public int Life { get; }

        public override void Draw(IDrawVisitor drawVisitor)
        {
            drawVisitor.DrawForPlayer(this);
        }
    }
}
