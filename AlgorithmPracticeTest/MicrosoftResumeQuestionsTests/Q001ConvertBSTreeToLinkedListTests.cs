using System;
using System.Collections.Generic;
using AlgorithmPractice.Commons;
using AlgorithmPractice.MicrosoftResumeQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPracticeTest.MicrosoftResumeQuestionsTests
{
    [TestClass]
    public partial class MicrosoftResumeQuestionsTests
    {
        [TestMethod]
        public void Q001ConvertBSTreeToLinkedListTest()
        {
            //     10
            //   /    \
            //  6     14
            // / \   /  \
            // 4  8 12  16
            // 转换成双向链表
            // 4=6=8=10=12=14=16

            var tree = new Node<int>(10,
                new Node<int>(6,
                    new Node<int>(4),
                    new Node<int>(8)),
                new Node<int>(14,
                    new Node<int>(12),
                    new Node<int>(16)));

            var expected1 = new List<int> { 4, 6, 8, 10, 12, 14, 16 };
            var expected2 = new List<int> { 16, 14, 12, 10, 8, 6, 4 };

            Node<int> head = null;
            Node<int> tail = null;
            try
            {
                Q001ConvertBSTreeToLinkedList.Convert(tree, out head, out tail);

            }
            catch (Exception e)
            {
                Assert.Fail(e.ToString());
            }

            // 遍历
            var actual1 = new List<int>();
            var actual2 = new List<int>();
            for (; head != null; head = head.LinkN)
            {
                actual1.Add(head.Value);
            }

            for (; tail != null; tail = tail.LinkP)
            {
                actual2.Add(tail.Value);
            }

            CollectionAssert.AreEqual(expected1, actual1);
            CollectionAssert.AreEqual(expected2, actual2);
        }
    }
}
