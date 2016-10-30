using AlgorithmPractice.Algorithms.Sort;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPracticeTest.Algorithms.Sort
{
    [TestClass]
    public class QuickSortTests
    {
        [TestMethod]
        public void TestQuickSort()
        {
            var a = new[] { 56, 26, 22, 68, 48, 42, 36, 84, 66 };
            var e = new[] { 22, 26, 36, 42, 48, 56, 66, 68, 84 };

            QuickSort.Sort(a, 0, a.Length - 1);

            CollectionAssert.AreEquivalent(e, a);
        }
    }
}
