namespace MatrixSort
{
    public class ComparerMaximumElement : IMatrixComparer
    {
        public int Comparer(int[] matrixRowFirst, int[] matrixRowSecond)
        {
            int maximumElement1 = MaximalElement(matrixRowFirst);
            int maximumElement2 = MaximalElement(matrixRowSecond);
            return maximumElement1 - maximumElement2;
        }
        private static int MaximalElement(int[] matrixRow)
        {
            int maximumElement = matrixRow[0];

            foreach (var item in matrixRow)
            {
                if (maximumElement < item)
                {
                    maximumElement = item;
                }
            }

            return maximumElement;
        }
    }
}
