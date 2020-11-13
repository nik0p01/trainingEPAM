using NUnit.Framework;

namespace StringHelper.Tests
{
    [TestFixture]
    public class DoubleCharTests
    {
        [Test]
        public void DoubleCharsTest()
        {
            var strIn1 = "omg i love shrek";
            var strIn2 = "o kek";
            var exp = "oomg  i  loovee  shreekk";
            var actual = DoubleChar.DoubleChars(strIn1, strIn2);
            Assert.AreEqual(exp, actual);
        }
    }
}