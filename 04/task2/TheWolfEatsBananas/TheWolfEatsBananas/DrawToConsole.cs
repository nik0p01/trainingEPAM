using System;

namespace TheWolvesAndBananas
{
    class DrawToConsole : IDrawVisitor
    {
        void IDrawVisitor.DrawForApple(Apple apple)
        {
            Console.WriteLine($"Это яблоко с ценностью {apple.Value} и координатами {apple.position}");
        }

        void IDrawVisitor.DrawForBanana(Banana banana)
        {
            Console.WriteLine($"Это банан  с ценностью {banana.Value} и координатами {banana.position}");
        }

        void IDrawVisitor.DrawForBear(Bear bear)
        {
            Console.WriteLine($"Это медведь  с координатами {bear.position}");
        }

        void IDrawVisitor.DrawForCherry(Cherry cherry)
        {
            Console.WriteLine($"Это вишинка  с ценностью {cherry.Value} и координатами {cherry.position}");
        }

        void IDrawVisitor.DrawForPlayer(Player player)
        {
            Console.WriteLine($"Это Вы  с жизнью {player.Life} и координатами {player.position}");
        }

        void IDrawVisitor.DrawForStone(Stone stone)
        {
            Console.WriteLine($"Это камень и координатами {stone.position}");
        }

        void IDrawVisitor.DrawForTree(Tree tree)
        {
            Console.WriteLine($"Это дерево и координатами {tree.position}");
        }

        void IDrawVisitor.DrawForWolf(Wolf wolf)
        {
            Console.WriteLine($"Это волк  с координатами {wolf.position}");
        }
    }
}
