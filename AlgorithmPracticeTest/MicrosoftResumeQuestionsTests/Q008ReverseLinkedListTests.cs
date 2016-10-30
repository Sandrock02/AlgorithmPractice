using System;
using AlgorithmPractice.Commons;
using AlgorithmPractice.MicrosoftResumeQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPracticeTest.MicrosoftResumeQuestionsTests
{
    public partial class MicrosoftResumeQuestionsTests
    {
        [TestMethod]
        public void Q008ReverseLinkedListTest()
        {
            var newHead = Q008ReverseLinkedList.Reverse<int>(null);
            Assert.IsNull(newHead);

            var head = new LinkedNode<int>(1);
            newHead = Q008ReverseLinkedList.Reverse(head);
            Assert.AreEqual(head, newHead);

            head = new LinkedNode<int>(10,
                new LinkedNode<int>(11));

            newHead = Q008ReverseLinkedList.Reverse(head);
            Assert.AreEqual(head, newHead.Next);

            head = new LinkedNode<int>(1);
            var tail = head
                .Append(new LinkedNode<int>(2))
                .Append(new LinkedNode<int>(3))
                .Append(new LinkedNode<int>(4))
                .Append(new LinkedNode<int>(5))
                .Append(new LinkedNode<int>(6))
                .Append(new LinkedNode<int>(7))
                .Append(new LinkedNode<int>(8))
                .Append(new LinkedNode<int>(9));

            newHead = Q008ReverseLinkedList.Reverse(head);
            Assert.AreEqual(tail, newHead);
        }
        
        [TestMethod]
        public void Q008ReverseLinkedListRecursiveTest()
        {
            var newHead = Q008ReverseLinkedList.ReverseRecursive<int>(null);
            Assert.IsNull(newHead);

            var head = new LinkedNode<int>(1);
            newHead = Q008ReverseLinkedList.ReverseRecursive(head);
            Assert.AreEqual(head, newHead);

            head = new LinkedNode<int>(10,
                new LinkedNode<int>(11));

            newHead = Q008ReverseLinkedList.ReverseRecursive(head);
            Assert.AreEqual(head, newHead.Next);

            head = new LinkedNode<int>(1);
            var tail = head
                .Append(new LinkedNode<int>(2))
                .Append(new LinkedNode<int>(3))
                .Append(new LinkedNode<int>(4))
                .Append(new LinkedNode<int>(5))
                .Append(new LinkedNode<int>(6))
                .Append(new LinkedNode<int>(7))
                .Append(new LinkedNode<int>(8))
                .Append(new LinkedNode<int>(9));

            newHead = Q008ReverseLinkedList.ReverseRecursive(head);
            Assert.AreEqual(tail, newHead);
            Assert.AreEqual(null, head.Next);
        }
    }
}
