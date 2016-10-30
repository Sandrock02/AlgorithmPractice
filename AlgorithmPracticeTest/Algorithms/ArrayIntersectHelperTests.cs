using System;
using AlgorithmPractice.Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPracticeTest.Algorithms
{
    [TestClass]
    public class ArrayIntersectHelperTests
    {
        [TestMethod]
        public void TestArrayIntersectOneByOne()
        {
            TestArrayIntersectHelper(ArrayIntersectHelper.ArrayIntersectOneByOne);
        }

        [TestMethod]
        public void TestArrayIntersectOneByOneLinq()
        {
            TestArrayIntersectHelper(ArrayIntersectHelper.ArrayIntersectOneByOneLinq);
        }

        [TestMethod]
        public void TestArrayIntersectSort()
        {
            TestArrayIntersectHelper(ArrayIntersectHelper.ArrayIntersectSort);
        }

        [TestMethod]
        public void TestArrayIntersectHash()
        {
            TestArrayIntersectHelper(ArrayIntersectHelper.ArrayIntersectHash);
        }

        private void TestArrayIntersectHelper(Func<char[], char[], bool> arrayIntersectMethod)
        {
            const string shortString = "cabb";

            Assert.IsFalse(arrayIntersectMethod(null, null));
            Assert.IsFalse(arrayIntersectMethod(null, shortString.ToCharArray()));
            Assert.IsFalse(arrayIntersectMethod(shortString.ToCharArray(), null));
            Assert.IsFalse(arrayIntersectMethod(new char[0], new char[0]));
            Assert.IsFalse(arrayIntersectMethod(new char[0], shortString.ToCharArray()));
            Assert.IsFalse(arrayIntersectMethod(shortString.ToCharArray(), new char[0]));

            const string source1 = "abcdefghi";
            const string source2 = "jklmnopqrst";

            Assert.IsTrue(arrayIntersectMethod(source1.ToCharArray(), shortString.ToCharArray()));
            Assert.IsFalse(arrayIntersectMethod(source2.ToCharArray(), shortString.ToCharArray()));

            const string source3 = "abcdefg";
            Assert.IsTrue(arrayIntersectMethod(source3.ToCharArray(), shortString.ToCharArray()));
        }
    }
}
