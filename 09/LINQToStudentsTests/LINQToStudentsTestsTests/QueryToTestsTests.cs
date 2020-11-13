using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace LINQToStudentsTests.Tests
{
    [TestFixture()]
    public class QueryToTestsTests
    {

        [TestCaseSource(nameof(_dataForListContains))]

        public void DoQueryToTestsTest(IEnumerable<StudentTestResult> testsExpected, string query)
        {
            List<StudentTestResult> studentsTestsResultsInput = new List<StudentTestResult> { new StudentTestResult("Ivanov", "stage speech", 4, new DateTime(2015, 9, 15)),
                new StudentTestResult("Petrov", "ballet", 5, new DateTime(2015, 11, 19)),
                new StudentTestResult("Sidorov", "folk dancing", 4, new DateTime(2015, 9, 15))};

            var testsActual = new List<StudentTestResult>(QueryToTests.DoQueryToTests(query, studentsTestsResultsInput));

            Assert.That(testsActual, Is.EqualTo(testsExpected));

        }
        private static List<TestCaseData> _dataForListContains = new List<TestCaseData>(new[]
            {
                new TestCaseData( new List<StudentTestResult> { new StudentTestResult("Ivanov", "stage speech", 4, new DateTime(2015, 9, 15)) }, "-name Ivanov"),
                 new TestCaseData( new List<StudentTestResult> { new StudentTestResult("Petrov", "ballet", 5, new DateTime(2015, 11, 19)) }, "-test ballet"),
                 new TestCaseData( new List<StudentTestResult> { new StudentTestResult("Petrov", "ballet", 5, new DateTime(2015, 11, 19)) }, "-datefrom 16/09/2015"),
                 new TestCaseData( new List<StudentTestResult> { new StudentTestResult("Ivanov", "stage speech", 4, new DateTime(2015, 9, 15)),
                                                                 new StudentTestResult("Petrov", "ballet", 5, new DateTime(2015, 11, 19)),
                                                                 new StudentTestResult("Sidorov", "folk dancing", 4, new DateTime(2015, 9, 15)) }, "-sort name asc"),
                 new TestCaseData( new List<StudentTestResult> { new StudentTestResult("Sidorov", "folk dancing", 4, new DateTime(2015, 9, 15)),
                                                                 new StudentTestResult("Petrov", "ballet", 5, new DateTime(2015, 11, 19)),
                                                                 new StudentTestResult("Ivanov", "stage speech", 4, new DateTime(2015, 9, 15)),}, "-sort name desc"),

            });

    }
}