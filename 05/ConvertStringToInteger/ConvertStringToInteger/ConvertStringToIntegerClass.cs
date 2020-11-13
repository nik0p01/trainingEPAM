using NLog;
using System;

namespace ConvertStringToInteger
{
    public class ConvertStringToIntegerClass
    {
        private readonly ILogger _logger;
        public ConvertStringToIntegerClass(ILogger logger)
        {
            _logger = logger;
        }
        public int StringToInteger(string str)
        {
            _logger.Info($"The input string {str}");
            int result = 0;
            int mult = 1;
            bool negativeNumber = false;

            if (str.Length > 0 && str[0] == '-')
            {
                negativeNumber = true;
            }

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (negativeNumber && i == 0)
                {
                    break;
                }

                if (i != str.Length - 1)
                {
                    try
                    {
                        checked
                        {
                            mult *= 10;
                        }
                    }
                    catch (OverflowException e)
                    {
                        _logger.Error("The input number does not match Integer", e);
                        throw;
                    }
                }

                try
                {
                    checked
                    {
                        if (negativeNumber)
                        {
                            result -= mult * CharToInt(str[i]);
                        }
                        else
                        {
                            result += mult * CharToInt(str[i]);
                        }

                    }
                }
                catch (OverflowException e)
                {
                    _logger.Error("The input number does not match Integer", e);
                    throw;
                }

            }
            return result;
        }

        private static int CharToInt(char c)
        {
            int i = (int)(c - '0');
            if (i < 0 || i > 9)
            {
                var e = new ArgumentOutOfRangeException(c.ToString());
                throw e;
            }
            return i;
        }
    }
}
