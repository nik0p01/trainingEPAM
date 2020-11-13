namespace TheWolvesAndBananas
{
    public interface IDrawVisitor
    {
        internal void DrawForPlayer(Player player);


        internal void DrawForApple(Apple apples);


        internal void DrawForBear(Bear bear);


        internal void DrawForWolf(Wolf wolf);


        internal void DrawForBanana(Banana banana);
        internal void DrawForStone(Stone stone);
        internal void DrawForTree(Tree tree);

        internal void DrawForCherry(Cherry cherry);

    }
}