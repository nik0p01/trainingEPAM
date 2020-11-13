using NUnit.Framework;

namespace GenericsAndCollection.Tests
{
    [TestFixture()]
    public class ArrayHelperTests
    {
        [TestCase("ab", 1)]
        [TestCase("cd", 4)]
        public void BinarySearchTest(string value, int exp)
        {
            string[] arrIn = { "a", "ab", "bc", "bc", "cd" };

            var actual = ArrayHelper.BinarySearch<string>(arrIn, value);
            Assert.AreEqual(exp, actual);
        }
    }
}