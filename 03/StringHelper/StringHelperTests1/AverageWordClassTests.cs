using NUnit.Framework;

namespace StringHelper.Tests
{
    [TestFixture]
    public class AverageWordClassTests
    {
        [Test]
        public void AverageWordTest()
        {
            string strIn = "1234, 12345?12.    123;1.0";
            double exp = 16.0 / 6;

            var actual = AverageWordClass.AverageWord(strIn);
            Assert.AreEqual(exp, actual);
        }
    }
}


