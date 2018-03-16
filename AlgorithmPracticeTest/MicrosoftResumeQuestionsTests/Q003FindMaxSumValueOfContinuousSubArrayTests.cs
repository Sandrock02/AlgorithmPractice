namespace AlgorithmPracticeTest.MicrosoftResumeQuestionsTests
{
    using AlgorithmPractice.ResumeQuestions;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public partial class MicrosoftResumeQuestionsTests
    {
        [TestMethod]
        public void Q003FindMaxSumValueOfContinuousSubArrayTest()
        {
            var array = new[] { 1, -2, 3, 10, -4, 7, 2, -5 };
            var max = Q003FindMaxSumValueOfSubArray.FindMaxSumValueOfContinuousSubArray(array);
            Assert.AreEqual(18, max);

            array = new[] { -2, -9, -5, -10, -1, -20 };
            max = Q003FindMaxSumValueOfSubArray.FindMaxSumValueOfContinuousSubArray(array);
            Assert.AreEqual(-1, max);
        }

        [TestMethod]
        public void Q003FindMaxSumValueOfNonContinuousSubArrayTest()
        {
            var array = new[] { 1, -2, 3, 10, -4, 7, 2, -5 };
            var max = Q003FindMaxSumValueOfSubArray.FindMaxSumValueOfNonContinuousSubArray(array);

            Assert.AreEqual(18, max);
        }
    }
}
