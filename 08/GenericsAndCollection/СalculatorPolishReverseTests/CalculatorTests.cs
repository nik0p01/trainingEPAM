using NUnit.Framework;

namespace СalculatorPolishReverse.Tests
{
    [TestFixture()]
    public class CalculatorTests
    {     
        [TestCase(" 5 1 2 + 4 * + 3 - ", 14)]
        [TestCase(" 1 2 + 4 * 3 -", 9)]
        [TestCase("", 0)]
        public void CalcStringTest(string input, int exp)
        {
            double actual = ReversePolishСalculator.Сalculator(input);
            Assert.AreEqual(exp, actual);
        }
    }
}