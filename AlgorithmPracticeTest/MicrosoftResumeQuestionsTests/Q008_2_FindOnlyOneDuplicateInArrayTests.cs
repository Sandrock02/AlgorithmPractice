using System;
using AlgorithmPractice.ResumeQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPracticeTest.MicrosoftResumeQuestionsTests
{
    [TestClass]
    public class Q008_2_FindOnlyOneDuplicateInArrayTests
    {
        [TestMethod]
        public void TestFindDuplicate()
        {
            var array = new int[1001];
            for (int i = 0; i < 1000; i++) array[i] = 1000 - i;
            array[1000] = 9999;

            var actual = Q008_2_FindOnlyOneDuplicateInArray.FindDuplicate(array);
            var expect = 9999;
            Assert.AreEqual(expect, actual);
        }
    }
}
