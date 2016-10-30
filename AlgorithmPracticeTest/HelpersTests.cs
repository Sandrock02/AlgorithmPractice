using System;
using AlgorithmPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPracticeTest
{
    [TestClass]
    public class HelpersTests
    {
        #region Test GCD method

        [TestMethod]
        public void TestGCD()
        {
            var expected = 3;
            var actual = CommonHelpers.GCD(12, 3);
            Assert.AreEqual(expected, actual);

            expected = 6;
            actual = CommonHelpers.GCD(12, 6);
            Assert.AreEqual(expected, actual);

            expected = 1;
            actual = CommonHelpers.GCD(13, 7);
            Assert.AreEqual(expected, actual);

            expected = 3;
            actual = CommonHelpers.GCD(3, 12);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGCDNegative1()
        {
            CommonHelpers.GCD(100, -100);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGCDNegative2()
        {
            CommonHelpers.GCD(-100, 100);
        }

        #endregion

        #region Test Revert<T> method
        [TestMethod]
        public void TestRevert()
        {
            char[] actual = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            var expected = "cbadefghijklmnopqrstuvwxyz".ToCharArray();
            CommonHelpers.Revert(actual, 0, 3);
            CollectionAssert.AreEqual(expected, actual);
        }

        #endregion


    }
}
