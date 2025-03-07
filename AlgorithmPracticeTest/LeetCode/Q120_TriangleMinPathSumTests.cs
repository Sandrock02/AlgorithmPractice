using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmPractice.LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPracticeTest.LeetCode
{
    [TestClass]
    public class Q120_TriangleMinPathSumTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var triangle = new List<IList<int>>()
            {
                new List<int> { 2 }, 
                new List<int> { 3, 4 }, 
                new List<int> { 6, 5, 7 }, 
                new List<int> { 4, 1, 8, 3 }
            };

            var expected = 11;

            var result = Q120_TriangleMinPathSum.MinimumTotal(triangle);
            Assert.AreEqual(expected, result);
        }
        
        [TestMethod]
        public void TestMethod2()
        {
            var triangle = new List<IList<int>>()
            {
                new List<int> { -10 }, 
            };

            var expected = -10;

            var result = Q120_TriangleMinPathSum.MinimumTotal(triangle);
            Assert.AreEqual(expected, result);
        }
    }
}
