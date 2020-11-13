using NUnit.Framework;
using System.Collections.Generic;

namespace StringHelper.Tests
{
    [TestFixture()]
    public class TakePhonesTests
    {
        [TestCaseSource(nameof(_dataForTakePhones))]
        public void TakePhonesFromStringTest(string input, List<string> expected)
        {
            var actual = TakePhones.TakePhonesFromString(input);
            Assert.That(actual, Is.EqualTo(expected));
        }

        private static List<TestCaseData> _dataForTakePhones = new List<TestCaseData>(new[]
    {
        new TestCaseData("Bla bla bla my number is +7 (921) 345-67-89 kekeke Blo Blo blo +375 (34) 444-7843 ololo", new List<string> (new string[] { "+7 (921) 345-67-89", "+375 (34) 444-7843"})),
        new TestCaseData(string.Empty, new List<string>())
    });

    }
}