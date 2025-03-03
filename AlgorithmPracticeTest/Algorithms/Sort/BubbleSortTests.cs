using System;
using AlgorithmPractice.Algorithms.Sort;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPracticeTest.Algorithms.Sort
{
    [TestClass]
    public class BubbleSortTests
    {
        [TestMethod]
        public void TestBubbleSort()
        {
            var a = new[] { 56, 26, 22, 68, 48, 42, 36, 84, 66 };
            var e = new[] { 22, 26, 36, 42, 48, 56, 66, 68, 84 };

            BubbleSort.Sort(a);

            CollectionAssert.AreEquivalent(e, a);
        }

        [TestMethod]
        public void TestBubbleSortWithNull()
        {
            var a = Array.Empty<int>();
            var e = Array.Empty<int>();

            BubbleSort.Sort(a);

            CollectionAssert.AreEquivalent(e, a);
        }
    }
}
