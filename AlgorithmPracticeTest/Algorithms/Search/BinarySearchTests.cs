using System;
using AlgorithmPractice.Algorithms.Search;
using AlgorithmPractice.Commons;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPracticeTest.Algorithms.Search
{
    [TestClass]
    public class BinarySearchTests
    {
        [TestMethod]
        public void TestBinarySearchInt()
        {
            var array = new [] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            var actual = BinarySearch.Search(array, 3);
            var expect = 2;
            Assert.AreEqual(expect, actual);
        }
        
        [TestMethod]
        public void TestBinarySearchInt2()
        {
            var array = new [] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            var actual = BinarySearch.Search(array, 99);
            var expect = -1;
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestBinarySearchGeneric1()
        {
            var array = "abcdefghijklmn".ToCharArray();
            var actual = BinarySearch.Search(array, 'm');
            var expect = 12;
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestBinarySearchGeneric2()
        {
            var array = "abcdefghijklmn".ToCharArray();
            var actual = BinarySearch.Search(array, 'c');
            var expect = 2;
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestBinarySearchGeneric3()
        {
            var array = new[]
            {
                new Node<int>(1),
                new Node<int>(2),
                new Node<int>(3),
                new Node<int>(4),
            };
            var actual = BinarySearch.Search(array, new Node<int>(3));
            var expect = 2;
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestBinarySearchNotFound()
        {
            var array = "abcdefghijklmn".ToCharArray();
            var actual = BinarySearch.Search(array, 'z');
            var expect = -1;
            Assert.AreEqual(expect, actual);
        }
    }
}
