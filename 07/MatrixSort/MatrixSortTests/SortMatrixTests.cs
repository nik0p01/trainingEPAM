using NUnit.Framework;

namespace MatrixSort.Tests
{
    [TestFixture()]
    public class SortMatrixTests
    {

        [Test()]
        public void SortMatrixRowSumAscTest()
        {
            int[][] input = SortMatrix.matrixHardCode;
            int[][] expected = { new int[] { 0, 1 }, new int[] { 2, 3 }, new int[] { 4, 5 } };
            var sortMatrix = new SortMatrix(new ComparerSumsOfMatrixRowElements());
            var actual = sortMatrix.SortMatrixRows(input);
            CollectionAssert.AreEqual(expected, actual);
        }
        [Test()]
        public void SortMatrixRowSumDescTest()
        {
            int[][] input = SortMatrix.matrixHardCode;
            int[][] expected = { new int[] { 4, 5 }, new int[] { 2, 3 }, new int[] { 0, 1 } };
            var sortMatrix = new SortMatrix(new ComparerSumsOfMatrixRowElementsDesc());
            var actual = sortMatrix.SortMatrixRows(input);
            CollectionAssert.AreEqual(expected, actual);
        }
        [Test()]
        public void SortMatrixRowMaxAscTest()
        {
            int[][] input = SortMatrix.matrixHardCode;
            int[][] expected = { new int[] { 0, 1 }, new int[] { 2, 3 }, new int[] { 4, 5 } };
            var sortMatrix = new SortMatrix(new ComparerMaximumElement());
            var actual = sortMatrix.SortMatrixRows(input);
            CollectionAssert.AreEqual(expected, actual);
        }
        [Test()]
        public void SortMatrixRowMaxDescTest()
        {
            int[][] input = SortMatrix.matrixHardCode;
            int[][] expected = { new int[] { 4, 5 }, new int[] { 2, 3 }, new int[] { 0, 1 } };
            var sortMatrix = new SortMatrix(new ComparerMaximumElementDesc());
            var actual = sortMatrix.SortMatrixRows(input);
            CollectionAssert.AreEqual(expected, actual);
        }
        [Test()]
        public void SortMatrixRowMinAscTest()
        {
            int[][] input = SortMatrix.matrixHardCode;
            int[][] expected = { new int[] { 0, 1 }, new int[] { 2, 3 }, new int[] { 4, 5 } };
            var sortMatrix = new SortMatrix(new ComparerMinimumElement());
            var actual = sortMatrix.SortMatrixRows(input);
            CollectionAssert.AreEqual(expected, actual);
        }
        [Test()]
        public void SortMatrixRowMinDescTest()
        {
            int[][] input = SortMatrix.matrixHardCode;
            int[][] expected = { new int[] { 4, 5 }, new int[] { 2, 3 }, new int[] { 0, 1 } };
            var sortMatrix = new SortMatrix(new ComparerMinimumElementDesc());
            var actual = sortMatrix.SortMatrixRows(input);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}