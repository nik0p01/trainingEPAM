using System.Text;

namespace StringHelper
{
    public class ReverseWordsOrderClass
    {

        public static string ReverseWordsOrder(string str)
        {
            var wordsList = StringToWordsClass.StringToWords(str);
            StringBuilder resultSB = new StringBuilder();
            for (int i = wordsList.Count - 1; i >= 0; i--)
            {
                if (i != wordsList.Count - 1)
                {
                    resultSB.Append(' ');
                }
                resultSB.Append(wordsList[i]);
            }
            return resultSB.ToString();
        }
    }
}
