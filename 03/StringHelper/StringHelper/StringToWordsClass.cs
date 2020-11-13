using System.Collections.Generic;

namespace StringHelper
{
    public static class StringToWordsClass
    {
        private readonly static char[] _separators = { ',', '.', '!', '?', ';', ':', ' ' };
        public static List<string> StringToWords(string str)
        {
            if (str is null)
            {
                return null;
            }

            var listStringSplit = str.Split(_separators);
            List<string> resultListWords = new List<string>();
            foreach (var item in listStringSplit)
            {
                if (item.Length > 0)
                {
                    resultListWords.Add(item);
                }
            }

            return resultListWords;
        }
    }
}
