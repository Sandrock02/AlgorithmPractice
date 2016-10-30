using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPracticeTest
{
    [TestClass]
    public class CsvParserTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var input = "Id,\"Detailed Description:\r\nTest Content with \\\"Special Content\\\"\"";
        }
    }

    
}
