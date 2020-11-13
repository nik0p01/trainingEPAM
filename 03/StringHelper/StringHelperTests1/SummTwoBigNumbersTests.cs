using NUnit.Framework;

namespace StringHelper.Tests
{
    [TestFixture]
    public class SummTwoBigNumbersTests
    {
        [TestCase("101", "99", "200")]
        [TestCase("901", "99", "1000")]
        public void SummTwoBigNumberTest(string strIn1, string strIn2, string exp)
        {
            var actual = SumTwoBigNumberClass.SumTwoBigNumbers(strIn1, strIn2);
            Assert.AreEqual(exp, actual);
        }
    }
}