using NUnit.Framework;

namespace GenericsAndCollection.Tests
{
    [TestFixture()]
    public class FibonacciTests
    {
        [Test()]
        public void GetEnumeratorTest()
        {
            int[] expArr = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };
            int[] fibArr = new int[expArr.Length];
            int i = 0;
            Fibonacci fib = new Fibonacci();
            foreach (var item in fib)
            {
                if (i == fibArr.Length)
                {
                    break;
                }
                fibArr[i] = item;
                i++;
            }
            CollectionAssert.AreEqual(expArr, fibArr);
        }
    }
}