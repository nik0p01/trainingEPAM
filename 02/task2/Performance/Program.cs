using System;
using System.Diagnostics;

namespace Performance
{
    class Program
    {
        static void Main(string[] args)
        {
            C[] classes;
            S[] structs;
            WorkWithMemory(out classes, out structs);
            WorkWithTime(classes, structs);
            Console.ReadLine();
        }

        private static void WorkWithTime(C[] classes, S[] structs)
        {
            var StartTime = Environment.TickCount;
            Array.Sort<S>(structs, (x, y) => x.i.CompareTo(y.i));
            long delte = CalculateTimeDelta(StartTime);
            Console.WriteLine($"Time to sort an array of structures {delte }");
            StartTime = Environment.TickCount;
            Array.Sort<C>(classes, (x, y) => x.i.CompareTo(y.i));
            delte = CalculateTimeDelta(StartTime);
            Console.WriteLine($"Time to sort an array of classes { delte}");
        }

        private static long CalculateTimeDelta(int StartTime)
        {
            return Environment.TickCount - StartTime;
        }

        private static void WorkWithMemory(out C[] classes, out S[] structs)
        {
            var memory = Process.GetCurrentProcess().PrivateMemorySize64;
            classes = new C[100000];
            long memoryForNewClasses = CalculateMemoryDelta(memory);
            Console.WriteLine($"memory for create array of classes {memoryForNewClasses}");
            memory = Process.GetCurrentProcess().PrivateMemorySize64;
            structs = new S[100000];
            long memoryForNewStacters = CalculateMemoryDelta( memory);
            Console.WriteLine($"memory for create array of structures {memoryForNewStacters}");
            Console.WriteLine($" Delta between memory for creation and filling of classes and memory for creation and  of  structures  {memoryForNewClasses - memoryForNewStacters}");
            Random rnd = new Random();
            memory = Process.GetCurrentProcess().PrivateMemorySize64;
            for (int i = 0; i < classes.Length; i++)
            {
                classes[i] = new C { i = rnd.Next() };
            }
            var memoryForFillingClasses = CalculateMemoryDelta( memory);
            Console.WriteLine($"filling array of classes {memoryForFillingClasses}");
            memory = Process.GetCurrentProcess().PrivateMemorySize64;
            for (int i = 0; i < structs.Length; i++)
            {
                structs[i] = new S { i = rnd.Next() };
            }
            var memoryForFillingStructs = CalculateMemoryDelta( memory);
            Console.WriteLine($"filling array of structs {memoryForFillingStructs}");
            Console.WriteLine($" Delta between memory for filling of classes and memory for filling of  structures  {memoryForFillingClasses - memoryForFillingStructs}");
        }

        private static long CalculateMemoryDelta(long memory)
        {
             return Process.GetCurrentProcess().PrivateMemorySize64 - memory;
        }
    }



}
