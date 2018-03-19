using System;
using AlgorithmPractice.ResumeQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPracticeTest.MicrosoftResumeQuestionsTests
{
    [TestClass]
    public class Q507ConvertStringToIntTests
    {
        [TestMethod]
        public void TestConvertString_Normal()
        {
            var input = "123456";
            var actual = Q507ConvertStringToInt.ConvertString(input);
            Assert.AreEqual(123456, actual);
        }

        [TestMethod]
        public void TestConvertString_PositiveValue()
        {
            var input = "+123456";
            var actual = Q507ConvertStringToInt.ConvertString(input);
            Assert.AreEqual(123456, actual);
        }

        [TestMethod]
        public void TestConvertString_NagetiveValue()
        {
            var input = "-123456";
            var actual = Q507ConvertStringToInt.ConvertString(input);
            Assert.AreEqual(-123456, actual);
        }

        [TestMethod]
        public void TestConvertString_MaxInt()
        {
            var input = "2147483647";
            var actual = Q507ConvertStringToInt.ConvertString(input);
            Assert.AreEqual(2147483647, actual);
        }

        [TestMethod]
        public void TestConvertString_MinInt()
        {
            var input = "-2147483648";
            var actual = Q507ConvertStringToInt.ConvertString(input);
            Assert.AreEqual(-2147483648, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestConvertString_EmptyString()
        {
            var input = "";
            Q507ConvertStringToInt.ConvertString(input);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "There is unsupported character in str.")]
        public void TestConvertString_AllNonNumString()
        {
            var input = "aaaaaaa";
            Q507ConvertStringToInt.ConvertString(input);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "The input number is greater than 2147483647.")]
        public void TestConvertString_MaxOverflow()
        {
            var input = "2147483648";
            Q507ConvertStringToInt.ConvertString(input);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "The input number is smaller than -2147483648.")]
        public void TestConvertString_MinOverflow()
        {
            var input = "-2147483649";
            Q507ConvertStringToInt.ConvertString(input);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "There is unsupported character in str.")]
        public void TestConvertString_IncludeNonNumString()
        {
            var input = "12345a";
            Q507ConvertStringToInt.ConvertString(input);
        }

        [TestMethod]
        public void TestConvertString_IncludeDotString()
        {
            var input = "12345.6";
            var actual = Q507ConvertStringToInt.ConvertString(input);
            Assert.AreEqual(12345, actual);
        }
    }
}
