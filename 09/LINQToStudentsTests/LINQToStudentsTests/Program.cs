using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace LINQToStudentsTests
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                if (!File.Exists("student test result.json"))
                {
                    CreateJsonTestFile();
                }
                var studentTestResults = ReadJsonFile();

                Console.WriteLine("Hello! Please input your criteria:");
                var request = Console.ReadLine();
                var resultTests =  QueryToTests.DoQueryToTests(request, studentTestResults);
                foreach (var test in resultTests)
                {
                    Console.WriteLine($"{test}{Environment.NewLine}");
                }
            }
        }

        private static ICollection<StudentTestResult> ReadJsonFile()
        {
            var jsonTextTack = File.ReadAllText("student test result.json");
            List<StudentTestResult> studentTestResultsFromFile = JsonConvert.DeserializeObject<List<StudentTestResult>>(jsonTextTack);
            return studentTestResultsFromFile;
        }

        private static void CreateJsonTestFile()
        {
            List<StudentTestResult> studentTestResults = new List<StudentTestResult> { new StudentTestResult("Ivanov", "stage speech", 4, new DateTime(2015, 9, 15)),
                new StudentTestResult("Petrov", "ballet", 5, new DateTime(2015, 11, 19)),
                new StudentTestResult("Sidorov", "folk dancing", 4, new DateTime(2015, 9, 15))};
            string json = JsonConvert.SerializeObject(studentTestResults, Formatting.Indented);
            File.WriteAllText("student test result.json", json);
        }
    }
}
