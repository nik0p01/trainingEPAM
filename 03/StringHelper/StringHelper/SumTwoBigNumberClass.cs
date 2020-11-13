using System;
using System.Collections.Generic;

namespace StringHelper
{
    public class SumTwoBigNumberClass
    {

        public static string SumTwoBigNumbers(string s1, string s2)
        {
            if (s1 is null || s2 is null)
            {
                return null;
            }
            List<char> resultCharsList = new List<char>();
            char[] s1Char = s1.ToCharArray();
            char[] s2Char = s2.ToCharArray();

            Array.Reverse(s1Char);
            Array.Reverse(s2Char);
            var moreThen10 = false;
            int maximalLengthOfNumber = s1Char.Length > s2Char.Length ? s1Char.Length : s2Char.Length;
            for (int i = 0; i < maximalLengthOfNumber; i++)
            {
                var num1 = 0;
                var num2 = 0;
                if (i < s1Char.Length)
                {
                    if (!int.TryParse(s1Char[i].ToString(), out num1))
                    {
                        throw new Exception("Строка 1 не число");
                    }

                }
                if (i < s2Char.Length)
                {
                    if (!int.TryParse(s2Char[i].ToString(), out num2))
                    {
                        throw new Exception("Строка 2 не число");
                    }
                }

                var sum = num1 + num2 + (moreThen10 ? 1 : 0);
                moreThen10 = sum >= 10;
                resultCharsList.Add((sum % 10).ToString().ToCharArray()[0]);
            }
            if (moreThen10)
            {
                resultCharsList.Add('1');
            }

            resultCharsList.Reverse();
            var result = String.Join(null, resultCharsList);


            return result;
        }
    }
}
