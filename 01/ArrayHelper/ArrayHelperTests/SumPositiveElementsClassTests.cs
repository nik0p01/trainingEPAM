using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArrayHelper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayHelper.Tests
{
    [TestClass()]
    public class SumPositiveElementsClassTests
    {
        [TestMethod()]
        public void SumPositiveElementsTest()
        {
            // arrange
            var intArrayIn = new int[,] { { -10, 10 }, { 0, 2 } };
            int Expected = 12;
            // act 
            var value = SumPositiveElementsClass.GetSumPositiveElements(intArrayIn).Value;
            var valueNull = SumPositiveElementsClass.GetSumPositiveElements(null);
            //assert
            Assert.AreEqual(Expected, value);
            Assert.AreEqual(null, valueNull);
        }
    }
}