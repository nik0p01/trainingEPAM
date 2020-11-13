using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayHelper
{
    public class SumPositiveElementsClass
    {
        public int[,] ArrInt { get; set; } = { { 6, -4 }, { 3, 8 }, { 9, 4 }, { -95, 0 }, { 46, 646 }, { 94, 33 }, { -99, 3 }, { 6953, 26 }, { -53, -566 }, { 656, 6 } };

        public int? GetSumPositiveElements()
        {
            if (ArrInt == null)
            {
                return null;
            }
            int result = 0;
            foreach (var item in ArrInt)
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
