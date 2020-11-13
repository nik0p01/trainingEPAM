using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayHelper
{
    public static class SumPositiveElementsClass
    {
        public static int? GetSumPositiveElements(int[,] arrInt)
        {
            if (arrInt == null)
            {
                return null;
            }
            int result = 0;
            foreach (var item in arrInt)
            {
                if (item > 0)
                {
                    result += item;
                }
            }
            return result;

        }
    }
}
