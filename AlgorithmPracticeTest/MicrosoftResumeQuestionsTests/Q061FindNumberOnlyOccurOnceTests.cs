using System;
using AlgorithmPractice.MicrosoftResumeQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPracticeTest.MicrosoftResumeQuestionsTests
{
    public partial class MicrosoftResumeQuestionsTests
    {
        [TestMethod]
        public void Q061FindNumberOnlyOccurOnceTest()
        {
            var a = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            var result = Q061FindNumberOnlyOccurOnce.FindNumberOnlyOccurOnce(a);
            Console.WriteLine(result.Item1);
            Console.WriteLine(result.Item2);
        }
    }
}
