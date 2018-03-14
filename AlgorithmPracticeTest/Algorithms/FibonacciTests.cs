using System;
using System.Diagnostics;
using AlgorithmPractice.Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPracticeTest.Algorithms
{
    [TestClass]
    public class FibonacciTests
    {
        private static Tuple<int, long>[] _Tests =
        {
            new Tuple<int, long>(1, 1),
            new Tuple<int, long>(2, 1),
            new Tuple<int, long>(3, 2),
            new Tuple<int, long>(10, 55),
            new Tuple<int, long>(30, 832040)
        };

        [TestMethod]
        public void TestGetNByRecursive()
        {
            foreach (var test in _Tests)
            {
                Debug.WriteLine($"Calculating {test.Item1}");
                Assert.AreEqual(test.Item2, Fibonacci.GetNByRecursive(test.Item1));
            }
        }

        [TestMethod]
        public void TestGetNByIteration()
        {
            foreach (var test in _Tests)
            {
                Debug.WriteLine($"Calculating {test.Item1}");
                Assert.AreEqual(test.Item2, Fibonacci.GetNByIteration(test.Item1));
            }
        }

        [TestMethod]
        public void TestGetNByCommonFormular()
        {
            foreach (var test in _Tests)
            {
                Debug.WriteLine($"Calculating {test.Item1}");
                Assert.AreEqual(test.Item2, Fibonacci.GetNByCommonFormular(test.Item1));
            }
        }

        [TestMethod]
        public void TestGetNByMatrix()
        {
            foreach (var test in _Tests)
            {
                Debug.WriteLine($"Calculating {test.Item1}");
                var actual = Fibonacci.GetNByMatrix(test.Item1);
                Assert.AreEqual(test.Item2, actual);
            }
        }
    }
}
