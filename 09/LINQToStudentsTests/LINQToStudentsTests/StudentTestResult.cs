using System;
using System.Globalization;

namespace LINQToStudentsTests
{

    public class StudentTestResult
    {
        public StudentTestResult()
        {
            studentName = default;
            testName = default;
            testResult = default;
            testDateTime = default;
        }
        public StudentTestResult(string studentName, string testName, byte testResult, DateTime testDateTime)
        {
            this.studentName = studentName;
            this.testName = testName;
            this.testResult = testResult;
            this.testDateTime = testDateTime;
        }

        public string studentName;
        public string testName;
        public byte testResult;
        public DateTime testDateTime;

        public override bool Equals(object obj)
        {
            if (obj is StudentTestResult)
            {
                var equalObj = obj as StudentTestResult;
                return studentName == equalObj.studentName && testName == equalObj.testName && testResult == equalObj.testResult && testDateTime == equalObj.testDateTime;
            }
            else
                return false;
        }

        public override string ToString()
        {
            return $"Student {studentName} passed {testName} with {testResult} marks on {testDateTime.ToString("dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo)}";
        }
    }
}
