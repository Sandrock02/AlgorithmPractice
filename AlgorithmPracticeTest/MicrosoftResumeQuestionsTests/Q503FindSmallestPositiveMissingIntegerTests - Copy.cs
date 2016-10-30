namespace AlgorithmPracticeTest.MicrosoftResumeQuestionsTests
{
    using AlgorithmPractice.MicrosoftResumeQuestions;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// MicrosoftResumeQuestions Tests
    /// </summary>
    public partial class MicrosoftResumeQuestionsTests
    {
        [TestMethod]
        public void TestFindSmallestPositiveMissingInteger()
        {
            var a = new[] { -1, -2, 1, 2, 3, 4 };

            var actual = Q503FindSmallestPositiveMissingInteger.FindMissingValue(a);
            Assert.AreEqual(5, actual);

            a = new[] { 1, 2, 3, 4 };

            actual = Q503FindSmallestPositiveMissingInteger.FindMissingValue(a);
            Assert.AreEqual(5, actual);


            a = new[] { -1, -2, 1, 2, 99, 4 };
            actual = Q503FindSmallestPositiveMissingInteger.FindMissingValue(a);
            Assert.AreEqual(3, actual);

            a = new[] { 99, 98, -100, 20, 0, 100 };
            actual = Q503FindSmallestPositiveMissingInteger.FindMissingValue(a);
            Assert.AreEqual(1, actual);

            a = new int[0];
            actual = Q503FindSmallestPositiveMissingInteger.FindMissingValue(a);
            Assert.AreEqual(1, actual);

            a = null;
            actual = Q503FindSmallestPositiveMissingInteger.FindMissingValue(a);
            Assert.AreEqual(1, actual);
        }
    }
}
