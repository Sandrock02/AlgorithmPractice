namespace AlgorithmPracticeTest.MicrosoftResumeQuestionsTests
{
    using AlgorithmPractice.ResumeQuestions;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public partial class MicrosoftResumeQuestionsTests
    {
        [TestMethod]
        public void TestQ505FindAllMoneyCombination()
        {
            var actual = Q505FindAllMoneyCombination.FindAllMoneyCombination(130, 3);
            var expected = new[] { @"100 x 1 | 20 x 1 | 10 x 1" };
            CollectionAssert.AreEquivalent(expected, actual);

            actual = Q505FindAllMoneyCombination.FindAllMoneyCombination(150, 6);
            expected = new[] 
            {
                @"100 x 1 | 20 x 1 | 10 x 2 | 5 x 2",
                @"100 x 1 | 10 x 5",
                @"50 x 2 | 20 x 2 | 5 x 2",
                @"50 x 2 | 20 x 1 | 10 x 3",
                @"50 x 1 | 20 x 5"
            };
            CollectionAssert.AreEquivalent(expected, actual);
        }
    }
}
