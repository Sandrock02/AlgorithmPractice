using System;
using AlgorithmPractice.ResumeQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPracticeTest.MicrosoftResumeQuestionsTests
{
    [TestClass]
    public class Q056LongestCommonSequenceTests
    {
        [TestMethod]
        public void TestLCS1()
        {
            var actual = Q056LongestCommonSequence.LCS("BDCABA", "ABCBDAB");
            var expect = "BCBA";
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestLCS2()
        {
            var actual = Q056LongestCommonSequence.LCS("acdabbc", "cddbacaba");
            var expect = "cdbc";
            Assert.AreEqual(expect, actual);
        }
    }
}
