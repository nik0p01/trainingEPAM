using NUnit.Framework;

namespace StringHelper.Tests
{
    [TestFixture]
    public class ReverseWordsOrderClassTests
    {
        [Test]
        public void ReverseWordsOrderTest()
        {
            var strIn = "The greatest victory is that which requires no battle";
            var exp = "battle no requires which that is victory greatest The";
            var actual = ReverseWordsOrderClass.ReverseWordsOrder(strIn);
            Assert.AreEqual(exp, actual);
        }
    }
}