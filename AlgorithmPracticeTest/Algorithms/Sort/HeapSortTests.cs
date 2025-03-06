using AlgorithmPractice.Algorithms.Sort;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPracticeTest.Algorithms.Sort
{
    [TestClass]
    public class HeapSortTests
    {
        [TestMethod]
        public void TestHeapSortNormal()
        {
            var a = new[] { 56, 26, 22, 68, 48, 42, 36, 84, 66 };
            var e = new[] { 22, 26, 36, 42, 48, 56, 66, 68, 84 };

            HeapSort.Sort(a);

            CollectionAssert.AreEquivalent(e, a);
        }

        [TestMethod]
        public void TestHeapSortWithNull()
        {
            var a = Array.Empty<int>();
            var e = Array.Empty<int>();

            HeapSort.Sort(a);

            CollectionAssert.AreEquivalent(e, a);
        }
    }
}
