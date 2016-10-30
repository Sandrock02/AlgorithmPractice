using AlgorithmPractice.Algorithms.Sort;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPracticeTest.Algorithms.Sort
{
    [TestClass]
    public class MergeSortTests
    {
        [TestMethod]
        public void TestMergeSort()
        {
            var a = new[] { 56, 26, 22, 68, 48, 42, 36, 84, 66 };
            var e = new[] { 22, 26, 36, 42, 48, 56, 66, 68, 84 };

            MergeSort.Sort(a);

            CollectionAssert.AreEquivalent(e, a);
        }
    }
}
