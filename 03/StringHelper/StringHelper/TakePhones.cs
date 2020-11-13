using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace StringHelper
{
    public class TakePhones
    {
        public static List<string> TakePhonesFromString(string inputText)
        {
            string pattern = @"[+]?\d{1,3}\s\(?\d{2,3}\)?\s\d{3}\-\d{2}\-?\d{2}";
            List<string> phoneNumbers = new List<string>();
            foreach (Match match in Regex.Matches(inputText, pattern, RegexOptions.IgnoreCase))
                phoneNumbers.Add(match.Value);
            return phoneNumbers;
        }
    }
}
