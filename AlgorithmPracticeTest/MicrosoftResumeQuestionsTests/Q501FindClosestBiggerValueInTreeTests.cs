namespace AlgorithmPracticeTest.MicrosoftResumeQuestionsTests
{
    using AlgorithmPractice.Commons;
    using AlgorithmPractice.MicrosoftResumeQuestions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public partial class MicrosoftResumeQuestionsTests
    {
        [TestMethod]
        public void Q501FindClosestBiggerValueInTree_1()
        {
            var root = BinaryTreeHelper.BuildTree(new[] {100, 50, 150, 25, 75, 125, 175});

            var result = Q501FindClosestBiggerValueInTree.FindClosestBiggerValue(root, 30);

            Assert.AreEqual(50, result.Value);
        }

        [TestMethod]
        public void Q501FindClosestBiggerValueInTree_2()
        {
            var root = BinaryTreeHelper.BuildTree(new[] { 100, 50, 150, 25, 75, 125, 175 });

            var result = Q501FindClosestBiggerValueInTree.FindClosestBiggerValue(root, 100);

            Assert.AreEqual(125, result.Value);
        }

        [TestMethod]
        public void Q501FindClosestBiggerValueInTree_3()
        {
            var root = BinaryTreeHelper.BuildTree(new[] { 100, 50, 150, 25, 75, 125, 175 });

            var result = Q501FindClosestBiggerValueInTree.FindClosestBiggerValue(root, 90);

            Assert.AreEqual(100, result.Value);
        }

        [TestMethod]
        public void Q501FindClosestBiggerValueInTree_4()
        {
            var root = BinaryTreeHelper.BuildTree(new[] { 100, 50, 150, 25, 75, 125, 175 });

            var result = Q501FindClosestBiggerValueInTree.FindClosestBiggerValue(root, 120);

            Assert.AreEqual(125, result.Value);
        }
        
        [TestMethod]
        public void Q501FindClosestBiggerValueExInTree_1()
        {
            var root = BinaryTreeHelper.BuildTree(new[] {100, 50, 150, 25, 75, 125, 175});

            var result = Q501FindClosestBiggerValueInTree.FindClosestBiggerValueEx(root, 30);

            Assert.AreEqual(50, result.Value);
        }

        [TestMethod]
        public void Q501FindClosestBiggerValueExInTree_2()
        {
            var root = BinaryTreeHelper.BuildTree(new[] { 100, 50, 150, 25, 75, 125, 175 });

            var result = Q501FindClosestBiggerValueInTree.FindClosestBiggerValueEx(root, 100);

            Assert.AreEqual(125, result.Value);
        }

        [TestMethod]
        public void Q501FindClosestBiggerValueExInTree_3()
        {
            var root = BinaryTreeHelper.BuildTree(new[] { 100, 50, 150, 25, 75, 125, 175 });

            var result = Q501FindClosestBiggerValueInTree.FindClosestBiggerValueEx(root, 90);

            Assert.AreEqual(100, result.Value);
        }

        [TestMethod]
        public void Q501FindClosestBiggerValueExInTree_4()
        {
            var root = BinaryTreeHelper.BuildTree(new[] { 100, 50, 150, 25, 75, 125, 175 });

            var result = Q501FindClosestBiggerValueInTree.FindClosestBiggerValueEx(root, 120);

            Assert.AreEqual(125, result.Value);
        }
    }
}
