using GenericsAndCollection;
using System;

namespace DemoArraysAndCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1-binary search, 2-Fibonacci numbers, 3-stack, 0-exit:");
            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("This is not an integer");
                Console.ReadLine();
                return;
            }

            if (choice == 1)
            {

                Console.WriteLine("Enter the string elements of the array in sorted form for binary search. The space is a separator:");
                var input = Console.ReadLine();
                var inputArr = input.Split(" ");
                Console.WriteLine("Enter an item to search for: ");
                var value = Console.ReadLine();

                var actual = ArrayHelper.BinarySearch<string>(inputArr, value);
                Console.WriteLine($"The index of the element: {actual}");
            }
            if (choice == 2)
            {
                int i = 0;
                Fibonacci fib = new Fibonacci();
                Console.WriteLine("Enter the output number of Fibonacci numbers: ");
                int.TryParse(Console.ReadLine(), out int valueInt);

                foreach (var item in fib)
                {
                    if (i == valueInt)
                    {
                        break;
                    }
                    Console.WriteLine($"{item} ");
                    i++;
                }
            }

            if (choice == 3)
            {
                Console.WriteLine($"Demonstration of stack operation:");
                MyStack<string> numbers = new MyStack<string>();
                numbers.Push("one");
                numbers.Push("two");
                numbers.Push("three");
                numbers.Push("four");
                numbers.Push("five");

                foreach (string number in numbers)
                {
                    Console.WriteLine(number);
                }
                Console.WriteLine($"{Environment.NewLine}Executing the Pop method '{numbers.Pop()}'");
                Console.WriteLine($"Executing the Peek method: {numbers.Peek()}");
                Console.WriteLine($"Executing the Pop method '{numbers.Pop()}'");
                Console.WriteLine($"The status of stack after execution of methods: ");
                foreach (string number in numbers)
                {
                    Console.WriteLine(number);
                }
            }

        }
    }
}
