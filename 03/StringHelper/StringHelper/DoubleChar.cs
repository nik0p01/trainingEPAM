using System;
using System.Text;

namespace StringHelper
{
    public static class DoubleChar
    {

        public static string DoubleChars(string strFirst, string strSecond)
        {
            if (strFirst is null || strSecond is null)
            {
                return null;
            }
            StringBuilder result = new StringBuilder();
            char[] strSecChars = strSecond.ToCharArray();
            foreach (var sign in strFirst)
            {
                if (Array.Exists(strSecChars, c => c == sign))
                {
                    result.Append(sign);
                }
                result.Append(sign);

            }
            return result.ToString();
        }
    }
}
