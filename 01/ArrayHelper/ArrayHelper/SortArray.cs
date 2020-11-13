using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayHelper
{
    public static class SortArray
    {
        public static int[] SortBubble(int[] arrInt, bool Asc = true)
        {
            if (arrInt is null)
            {
                return null;
            }
            int[] arrIntResult= (int[])arrInt.Clone();
            var len = arrIntResult.Length;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if ((arrIntResult[j] > arrIntResult[j + 1]) == Asc)
                    {
                        Swap(ref arrIntResult[j], ref arrIntResult[j + 1]);
                    }
                }
            }
            return arrIntResult;
        }
        private static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }
    }
}
