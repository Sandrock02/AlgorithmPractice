using AlgorithmPractice.ResumeQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPracticeTest.MicrosoftResumeQuestionsTests
{
    public partial class MicrosoftResumeQuestionsTests
    {
        [TestMethod]
        public void Q009CheckPostOrderResultTest()
        {
            var input = new[] { 5, 7, 6, 9, 11, 10, 8 };
            var result = Q009CheckPostOrderResult.VerifySquenceOfBst(input, input.Length);
            Assert.IsTrue(result);

            input = new[] { 7, 4, 6, 5 };
            result = Q009CheckPostOrderResult.VerifySquenceOfBst(input, input.Length);
            Assert.IsFalse(result);
        }
    }
}
