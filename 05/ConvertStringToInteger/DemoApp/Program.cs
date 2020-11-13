using ConvertStringToInteger;
using NLog;
using System;

namespace DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the number: ");
            var inStr = Console.ReadLine();

            Logger logger = LogManager.GetCurrentClassLogger();
            ConvertStringToIntegerClass convertStringToInteger = new ConvertStringToIntegerClass(logger);
            try
            {
                convertStringToInteger.StringToInteger(inStr);
            }
            catch (OverflowException e)
            {
                logger.Error("The input number does not match Integer", e);
            }
            catch (ArgumentOutOfRangeException e)
            {
                logger.Error($"The input string includes not allow symbol", e);
            }
        }
    }
}
