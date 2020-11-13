using System;

namespace MatrixSort
{
    public class ComparerSumsOfMatrixRowElementsDesc : IMatrixComparer
    {
        public int Comparer(int[] matrixRowFirst, int[] matrixRowSecond)
        {
            int sum1 = SumArray(matrixRowFirst);
            int sum2 = SumArray(matrixRowSecond);
            return sum2 - sum1;
        }
        private static int SumArray(int[] matrixRow)
        {
            int sum = 0;
            Array.ForEach<int>(matrixRow, a => sum += a);
            return sum;
        }
    }
}
