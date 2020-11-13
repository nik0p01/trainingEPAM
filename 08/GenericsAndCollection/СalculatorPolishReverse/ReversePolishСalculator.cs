using System;
using System.Collections.Generic;
using System.Text;

namespace СalculatorPolishReverse
{
    static public class ReversePolishСalculator
    {
        public static double Сalculator(string expression)
        {
            while (expression != null)
            {
                Stack<string> tks = new Stack<string>(expression.Split(' ', StringSplitOptions.RemoveEmptyEntries));
                if (tks.Count == 0)
                    break;
                try
                {
                    double r = Calc(tks);
                    if (tks.Count != 0) throw new Exception();
                    return r;
                }
                catch (Exception e)
                {
                    throw new ArgumentException("Not valid expression");
                }
            }
            return 0;
        }
        private static double Calc(Stack<string> tks)
        {
            string tk = tks.Pop();
            double x, y;
            if (!Double.TryParse(tk, out x))
            {
                y = Calc(tks);
                x = Calc(tks);
                if (tk == "+") x += y;
                else if (tk == "-") x -= y;
                else if (tk == "*") x *= y;
                else if (tk == "/") x /= y;
                else throw new ArgumentException("Not valid expression");
            }
            return x;
        }
    }
}