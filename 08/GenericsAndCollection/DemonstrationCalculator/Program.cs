using System;
using СalculatorPolishReverse;

namespace DemonstrationCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an expression to calculate: ");
            var input = Console.ReadLine();
            double actual;
            try
            {
                actual = ReversePolishСalculator.Сalculator(input);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            Console.WriteLine($"Result: {actual}");
        }
    }
}
