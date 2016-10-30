using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmPractice.Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPracticeTest.Algorithms
{
    [TestClass]
    public class HeapHelperTests
    {
        [TestMethod]
        public void BuildMinHeapTest()
        {
            var array = new[] {1, 5, 4, 6, 7, 9, 3};
            var expected = new[] { 1, 5, 3, 6, 7, 9, 4 };
            HeapHelper.BuildMinHeap(array);

            Console.WriteLine("Expected: {0}", string.Join(", ", expected));
            Console.WriteLine("  Actual: {0}", string.Join(", ", array));
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void BuildMaxHeapTest()
        {
            var array = new[] { 1, 5, 4, 6, 7, 9, 3 };
            var expected = new[] { 9, 7, 4, 6, 5, 1, 3 };
            HeapHelper.BuildMaxHeap(array);

            Console.WriteLine("Expected: {0}", string.Join(", ", expected));
            Console.WriteLine("  Actual: {0}", string.Join(", ", array));
            CollectionAssert.AreEqual(expected, array);
        }
    }
}
