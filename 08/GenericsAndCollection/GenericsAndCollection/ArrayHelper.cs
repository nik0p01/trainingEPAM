using System;

namespace GenericsAndCollection
{
    public static class ArrayHelper
    {
        public static int BinarySearch<T>(T[] array, T value)
        {
            if (!(value is IComparable))
            {
                throw new InvalidOperationException();
            }

            IComparable valueIC = value as IComparable;

            int min = 0;
            int max = array.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (valueIC.CompareTo(array[mid]) == 0)
                {
                    return mid;
                }
                else if (valueIC.CompareTo(array[mid]) < 0)
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }
    }
}
