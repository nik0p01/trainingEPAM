using System;

namespace MatrixSort
{
    public class ComparerSumsOfMatrixRowElements : IMatrixComparer
    {
        public int Comparer(int[] matrixRowFirst, int[] matrixRowSecond)
        {
            int sum1 = SumArray(matrixRowFirst);
            int sum2 = SumArray(matrixRowSecond);
            return sum1 - sum2;
        }
        private static int SumArray(int[] matrixRow)
        {
            int sum = 0;
            Array.ForEach<int>(matrixRow, a => sum += a);
            return sum;
        }
    }
}
