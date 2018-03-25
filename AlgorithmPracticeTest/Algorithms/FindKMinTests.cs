using System;
using System.Linq;
using AlgorithmPractice.Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPracticeTest.Algorithms
{
    [TestClass]
    public class FindKMinTests
    {
        private readonly FindKMin _findKMin = new FindKMin();

        [TestMethod]
        public void TestKMin1()
        {
            var array = new[]
            {
                11, 19, 71, 34, 47, 38, 55, 1, 33, 69, 10, 32, 41, 71, 50, 5, 86, 86, 38, 37, 92, 48, 94, 50, 21, 29,
                11, 65, 31, 17, 95, 75, 43, 30, 54, 88, 14, 26, 37, 98, 4, 65, 83, 90, 81, 40, 9, 48, 10, 38, 23, 74,
                36, 71, 79, 63, 25, 21, 12, 18, 26, 89, 69, 16, 74, 34, 89, 10, 16, 61, 90, 59, 48, 40, 33, 26, 64, 4,
                68, 81, 19, 62, 55, 93, 93, 21, 39, 71, 50, 91, 63, 93, 14, 19, 72, 14, 95, 67, 15, 47
            };
            var expect = new[] {1, 4, 4, 5, 9, 10, 10, 10, 11, 11};
            var actual = _findKMin.KMin(array, 10).ToArray();
            CollectionAssert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestKMin2()
        {
            var array = new[]
            {
                11, 19, 71, 34, 47, 38, 55, 1, 33, 69, 10, 32, 41, 71, 50, 5, 86, 86, 38, 37, 92, 48, 94, 50, 21, 29,
                11, 65, 31, 17, 95, 75, 43, 30, 54, 88, 14, 26, 37, 98, 4, 65, 83, 90, 81, 40, 9, 48, 10, 38, 23, 74,
                36, 71, 79, 63, 25, 21, 12, 18, 26, 89, 69, 16, 74, 34, 89, 10, 16, 61, 90, 59, 48, 40, 33, 26, 64, 4,
                68, 81, 19, 62, 55, 93, 93, 21, 39, 71, 50, 91, 63, 93, 14, 19, 72, 14, 95, 67, 15, 47
            };
            var expect = new[] {1, 4, 4, 5, 9, 10, 10, 10, 11, 11};
            var actual = _findKMin.KMin2(array, 10).ToArray();
            CollectionAssert.AreEqual(expect, actual.OrderBy(t=>t).ToArray());
        }
    }
}
