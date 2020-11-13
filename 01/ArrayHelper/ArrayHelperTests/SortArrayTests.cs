using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArrayHelper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayHelper.Tests
{
    [TestClass()]
    public class SortArrayTests
    {
        [TestMethod()]
        public void SortBubbleTest()
        {

            // arrange
            var intArrayIn = new int[] { -10, 10, 0, 2 };
            var intArrayExpectedAsc = new int[] { -10, 0, 2, 10 };
            var intArrayExpectedDesc = new int[] { 10, 2, 0, -10 };
            int[] intArrayInNull = null;
            // act  
            var intArrayAsc = SortArray.SortBubble(intArrayIn);
            var intArrayDesc = SortArray.SortBubble(intArrayIn, false);
            var intArrayDescNull = SortArray.SortBubble(intArrayInNull, false);
            //assert
            CollectionAssert.AreEqual(intArrayExpectedAsc, intArrayAsc);
            CollectionAssert.AreEqual(intArrayExpectedDesc, intArrayDesc);
            CollectionAssert.AreEqual(intArrayInNull, intArrayDescNull);



        }


    }
}