

namespace StringHelper
{
    public class AverageWordClass
    {

        public static double AverageWord(string str)
        {
            var wordsList = StringToWordsClass.StringToWords(str);
            int wordsLengthSum = 0;
            foreach (var w in wordsList)
            {
                wordsLengthSum += w.Length;
            }
            return wordsList.Count == 0 ? .0 : (double)wordsLengthSum / wordsList.Count;
        }
    }
}
