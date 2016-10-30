using System;
using AlgorithmPractice.Commons;
using AlgorithmPractice.MicrosoftResumeQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPracticeTest.MicrosoftResumeQuestionsTests
{
    public partial class MicrosoftResumeQuestionsTests
    {
        [TestMethod]
        public void Q101ReverseEvery2NodesInLinkedListTest()
        {
            RunTest(Q101ReverseEvery2NodesInLinkedList.Reverse);
        }

        [TestMethod]
        public void Q101ReverseEvery2NodesInLinkedListTest2()
        {
            RunTest(Q101ReverseEvery2NodesInLinkedList.ReverseRecursivly);
        }

        private void RunTest(Func<LinkedNode<int>,  LinkedNode<int>> func)
        {
            var result = func(null);
            Assert.IsNull(result);

            var h = new LinkedNode<int>(0);
            result = func(h);
            Assert.AreEqual(h, result);

            h = new LinkedNode<int>(1);
            h.Append(new LinkedNode<int>(2))
            .Append(new LinkedNode<int>(3));
            result = func(h);
            var expected = new[] { 2, 1, 3 };
            CollectionAssert.AreEqual(expected, result.GetValueArray());

            h = new LinkedNode<int>(1);
            h.Append(new LinkedNode<int>(2))
                .Append(new LinkedNode<int>(3))
                .Append(new LinkedNode<int>(4))
                .Append(new LinkedNode<int>(5))
                .Append(new LinkedNode<int>(6))
                .Append(new LinkedNode<int>(7))
                .Append(new LinkedNode<int>(8));
            result = func(h);
            expected = new[] { 2, 1, 4, 3, 6, 5, 8, 7 };
            CollectionAssert.AreEqual(expected, result.GetValueArray());

            h = new LinkedNode<int>(1);
            h.Append(new LinkedNode<int>(2))
                .Append(new LinkedNode<int>(3))
                .Append(new LinkedNode<int>(4))
                .Append(new LinkedNode<int>(5))
                .Append(new LinkedNode<int>(6))
                .Append(new LinkedNode<int>(7));
            result = func(h);
            expected = new[] { 2, 1, 4, 3, 6, 5, 7 };
            CollectionAssert.AreEqual(expected, result.GetValueArray());
        }
    }
}
