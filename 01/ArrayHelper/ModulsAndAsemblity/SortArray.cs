using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayHelper
{
   public class SortArray
    {
        public int[] ArrInt { get; set; } = { 6, 4, 3, 8, 9, 4, 95, 65, 46, 646, 94, 33, 99, 3, 6953, 26, 53, 566, 656, 6 };
        public bool Asc { get; set; } = true;

        public void SortBubble()
        {
            var len = ArrInt.Length;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if ((ArrInt[j] > ArrInt[j + 1]) == Asc)
                    {
                        Swap(ref ArrInt[j], ref ArrInt[j + 1]);
                    }
                }
            }
        }

        private static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }
        public bool TestSort()
        {
            if (ArrInt==null || ArrInt.Length<=1)
            {
                return true;
            }
            int iInt= ArrInt[0];
            for (int i = 1; i < ArrInt.Length; i++)
            {
                var a = Asc ? (ArrInt[i]<= iInt) : (ArrInt[i] >= iInt);
                var b = ArrInt[i];
                if ( Asc? ArrInt[i] < iInt: ArrInt[i] > iInt)
                {
                    return false;
                }
                iInt = ArrInt[i];
            }         
            return true;
        }
    }
}
