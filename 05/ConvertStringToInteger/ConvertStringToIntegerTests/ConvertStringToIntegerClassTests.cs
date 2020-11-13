using Moq;
using NLog;
using NUnit.Framework;

namespace ConvertStringToInteger.Tests
{
    [TestFixture]
    public class ConvertStringToIntegerClassTests
    {
        [TestCase(0, "0")]
        [TestCase(-16785, "-16785")]
        [TestCase(int.MinValue, "-2147483648")]
        [TestCase(int.MaxValue, "2147483647")]
        public void StringToIntegerTest(int expected, string input)
        {
            var mockILogger = new Mock<ILogger>();

            ConvertStringToIntegerClass convertStringToInteger = new ConvertStringToIntegerClass(mockILogger.Object);
            var actual = convertStringToInteger.StringToInteger(input);

            Assert.AreEqual(expected, actual);
        }
    }
}