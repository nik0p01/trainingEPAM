namespace MatrixSort
{
    public class ComparerMinimumElementDesc : IMatrixComparer
    {
        public int Comparer(int[] matrixRowFirst, int[] matrixRowSecond)
        {
            int minimumElement1 = MinElement(matrixRowFirst);
            int minimumElement2 = MinElement(matrixRowSecond);
            return minimumElement2 - minimumElement1;
        }
        private static int MinElement(int[] matrixRow)
        {
            int minimumElement = matrixRow[0];
            foreach (var item in matrixRow)
            {
                if (minimumElement > item)
                {
                    minimumElement = item;
                }
            }

            return minimumElement;
        }
    }
}
