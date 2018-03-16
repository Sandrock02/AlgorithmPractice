using AlgorithmPractice.Commons;
using AlgorithmPractice.ResumeQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPracticeTest.MicrosoftResumeQuestionsTests
{
    public partial class MicrosoftResumeQuestionsTests
    {
        [TestMethod]
        public void Q016PrintBinaryTreeNodeByLevelTest()
        {
            var array = new[] {8, 6, 10, 5, 7, 9, 11};
            var invalidIndices = new[] {0, 1, 2, 3, 4, 5, 6};
            const string expected = "8 6 10 5 7 9 11 ";

            var root = BinaryTreeHelper.BuildTree(array, invalidIndices);

            var actual = Q016PrintBinaryTreeNodeByLevel.Print(root);

            Assert.AreEqual(expected, actual);
        }
    }
}
