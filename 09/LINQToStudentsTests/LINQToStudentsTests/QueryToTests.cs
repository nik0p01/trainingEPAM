using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace LINQToStudentsTests
{
    public class QueryToTests
    {
        public static IEnumerable<StudentTestResult> DoQueryToTests(string request, IEnumerable<StudentTestResult> tests)
        {
            var query = request.Split(" ");

            IEnumerable<StudentTestResult> result = new List<StudentTestResult>(tests);
            if (query.Length < 2)
            {
                return result;
            }
            for (int i = 0; i < query.Length; i++)
            {
                if (query[i] == "-sort")
                {
                    if (query.Length - i >= 3)
                    {
                        result = DoOneQueryOperation(query[i], query[i + 1], query[i + 2], result);
                        i += 2;
                    }
                    else
                    {
                        throw new ArgumentException("Wrong sort parameters");
                    }

                }
                else
                {
                    if (query.Length - i >= 2)
                    {
                        result = DoOneQueryOperation(query[i], query[i + 1], result);
                        i++;
                    }
                    else
                    {
                        throw new ArgumentException($"Wrong query string");
                    }
                }
            }
            return result;
        }

        private static IEnumerable<StudentTestResult> DoOneQueryOperation(string flag, string sortBy, string key, IEnumerable<StudentTestResult> tests)
        {
            bool asc = default;
            if (key == "asc")
            {
                asc = true;
            }
            else if (key == "desc")
            {
                asc = false;
            }
            else
            {
                throw new ArgumentException($"Wrong sort argument: {key}");
            }

            if (flag == "-sort")
            {
                if (sortBy == "name")
                {
                    return asc ? tests.OrderBy(t => t.studentName) : tests.OrderByDescending(t => t.studentName);
                }
                if (sortBy == "mark")
                {
                    return asc ? tests.OrderBy(t => t.testResult) : tests.OrderByDescending(t => t.testResult);
                }
                if (sortBy == "date")
                {
                    return asc ? tests.OrderBy(t => t.testDateTime) : tests.OrderByDescending(t => t.testDateTime);
                }
                if (sortBy == "test")
                {
                    return asc ? tests.OrderBy(t => t.testName) : tests.OrderByDescending(t => t.testName);
                }
                else
                {
                    throw new ArgumentException($"Wrong sort argument: {sortBy}");
                }
            }
            else
            {
                return tests;
            }
        }

        private static IEnumerable<StudentTestResult> DoOneQueryOperation(string flag, string value, IEnumerable<StudentTestResult> tests)
        {
            if (flag == "-name")
            {
                var result = from test in tests
                             where test.studentName == value
                             select test;
                return result;
            }
            else if (flag == "-minmark")
            {
                int markValue = TryParseMark(value);
                return from test in tests
                       where test.testResult >= markValue
                       select test;
            }
            else if (flag == "-maxmark")
            {
                int markValue = TryParseMark(value);
                return from test in tests
                       where test.testResult <= markValue
                       select test;
            }
            else if (flag == "-datefrom")
            {
                DateTime dateValue = TryParseDate(value);
                return from test in tests
                       where test.testDateTime >= dateValue
                       select test;
            }
            else if (flag == "-dateto")
            {
                DateTime dateValue = TryParseDate(value);
                return from test in tests
                       where test.testDateTime <= dateValue
                       select test;
            }
            else if (flag == "-test")
            {
                return from test in tests
                       where test.testName == value
                       select test;
            }
            else
                return tests;
        }

        private static DateTime TryParseDate(string value)
        {
            DateTime dt;
            try
            {
                dt = DateTime.ParseExact(value, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch
            {
                throw new ArgumentException($"Wrong date argument: {value}");
            }

            return dt;
        }

        private static int TryParseMark(string value)
        {
            if (!int.TryParse(value, out int markValue))
            {
                throw new ArgumentException($"Wrong mark argument: {value}");
            }
            return markValue;
        }
    }
}
