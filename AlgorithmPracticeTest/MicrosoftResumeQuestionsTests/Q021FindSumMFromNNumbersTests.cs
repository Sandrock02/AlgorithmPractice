using System;
using AlgorithmPractice.ResumeQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPracticeTest.MicrosoftResumeQuestionsTests
{
    public partial class MicrosoftResumeQuestionsTests
    {
        [TestMethod]
        public void Q021FindSumMFromNNumbers1Test()
        {
            Q021FindSumMFromNNumbers.FindSumM(6, 7);
        }

        [TestMethod]
        public void Q021FindSumMFromNNumbers2Test()
        {
            Q021FindSumMFromNNumbers.FindSumM(10, 12);
        }
    }
}
