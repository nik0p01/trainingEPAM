namespace MatrixSort
{
    public class SortMatrix
    {
        public SortMatrix(IMatrixComparer comparer)
        {
            _comparer = comparer.Comparer;
        }

        private Comparer _comparer;

        public static readonly int[][] matrixHardCode = { new int[] { 0, 1 }, new int[] { 2, 3 }, new int[] { 4, 5 } };

        public delegate int Comparer(int[] matrixRowFirst, int[] matrixRowSecond);
        public int[][] SortMatrixRows(int[][] matrix)
        {
            if (matrix is null)
            {
                return null;
            }
            var matrixResult = new int[matrix.Length][];
            for (int i = 0; i < matrix.Length; i++)
            {
                matrixResult[i] = (int[])matrix[i].Clone();
            }
            var len = matrix.Length;
            if (matrix.Length < 2)
            {
                return matrixResult;
            }
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    var comparison = _comparer(matrixResult[j], matrixResult[j + 1]);
                    if (comparison == 0)
                    {
                        continue;
                    }
                    if (comparison > 0)
                    {
                        SwapRows(matrixResult, j, j + 1);
                    }
                }
            }
            return matrixResult;
        }

        private static void SwapRows(int[][] matrix, int numberRowFirst, int numberRowSecond)
        {
            var temp = matrix[numberRowFirst];
            matrix[numberRowFirst] = matrix[numberRowSecond];
            matrix[numberRowSecond] = temp;
        }

    }
}
