using System;
using AlgorithmPractice.Algorithms.BigNumbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPracticeTest.Algorithms.BigNumbers
{
    [TestClass]
    public class BigNumberHelperTests
    {

        #region Plus
        [TestMethod]
        public void TestPlus()
        {
            int[] v1 = BigNumberHelper.GetArrayFromString("987654321");
            int[] v2 = BigNumberHelper.GetArrayFromString("765432");
            int[] ex = BigNumberHelper.GetArrayFromString("988419753");
            var actual = BigNumberHelper.Plus(v1, v2);
            CollectionAssert.AreEqual(ex, actual);
        }

        [TestMethod]
        public void TestPlusV1Empty()
        {
            int[] v1 = { };
            int[] v2 = BigNumberHelper.GetArrayFromString("987654321");
            int[] ex = BigNumberHelper.GetArrayFromString("987654321");
            var actual = BigNumberHelper.Plus(v1, v2);
            CollectionAssert.AreEqual(ex, actual);
        }

        [TestMethod]
        public void TestPlusV2Empty()
        {
            int[] v1 = BigNumberHelper.GetArrayFromString("987654321");
            int[] v2 = {};
            int[] ex = BigNumberHelper.GetArrayFromString("987654321");
            var actual = BigNumberHelper.Plus(v1, v2);
            CollectionAssert.AreEqual(ex, actual);
        }

        [TestMethod]
        public void TestPlusV1Null()
        {
            int[] v1 = null;
            int[] v2 = BigNumberHelper.GetArrayFromString("987654321");
            int[] ex = BigNumberHelper.GetArrayFromString("987654321");
            var actual = BigNumberHelper.Plus(v1, v2);
            CollectionAssert.AreEqual(ex, actual);
        }

        [TestMethod]
        public void TestPlusV2Null()
        {
            int[] v1 = BigNumberHelper.GetArrayFromString("987654321");
            int[] v2 = null;
            int[] ex = BigNumberHelper.GetArrayFromString("987654321");
            var actual = BigNumberHelper.Plus(v1, v2);
            CollectionAssert.AreEqual(ex, actual);
        }

        [TestMethod]
        public void TestPlusBothEmpty()
        {
            int[] v1 = {};
            int[] v2 = {};
            int[] ex = {};
            var actual = BigNumberHelper.Plus(v1, v2);
            CollectionAssert.AreEqual(ex, actual);
        }

        [TestMethod]
        public void TestPlusWithFinalCarry()
        {
            int[] v1 = BigNumberHelper.GetArrayFromString("654321");
            int[] v2 = BigNumberHelper.GetArrayFromString("765432");
            int[] ex = BigNumberHelper.GetArrayFromString("1419753");
            var actual = BigNumberHelper.Plus(v1, v2);
            CollectionAssert.AreEqual(ex, actual);
        }
        #endregion

        #region Minus

        [TestMethod]
        public void TestMinus()
        {
            int[] v1 = BigNumberHelper.GetArrayFromString("3333");
            int[] v2 = BigNumberHelper.GetArrayFromString("1111");
            int[] ex = BigNumberHelper.GetArrayFromString("2222");
            var actual = BigNumberHelper.Minus(v1, v2);
            CollectionAssert.AreEqual(ex, actual);
        }

        [TestMethod]
        public void TestMinusWithCarry()
        {
            int[] v1 = BigNumberHelper.GetArrayFromString("3333");
            int[] v2 = BigNumberHelper.GetArrayFromString("1999");
            int[] ex = BigNumberHelper.GetArrayFromString("1334");
            var actual = BigNumberHelper.Minus(v1, v2);
            CollectionAssert.AreEqual(ex, actual);
        }

        [TestMethod]
        public void TestMinusV1Smaller()
        {
            int[] v1 = BigNumberHelper.GetArrayFromString("1111");
            int[] v2 = BigNumberHelper.GetArrayFromString("1999");
            int[] ex = {0,0,0,0};
            var actual = BigNumberHelper.Minus(v1, v2);
            CollectionAssert.AreEqual(ex, actual);
        }

        #endregion

        #region Multiply

        [TestMethod]
        public void TestMultiply1()
        {
            int[] v1 = BigNumberHelper.GetArrayFromString("9999");
            int[] v2 = BigNumberHelper.GetArrayFromString("9999");
            int[] ex = BigNumberHelper.GetArrayFromString("99980001");
            var actual = BigNumberHelper.Multiply(v1, v2);
            CollectionAssert.AreEqual(ex, actual);
        }

        [TestMethod]
        public void TestMultiply2()
        {
            int[] v1 = BigNumberHelper.GetArrayFromString("123456789");
            int[] v2 = BigNumberHelper.GetArrayFromString("8888");
            int[] ex = BigNumberHelper.GetArrayFromString("1097283940632");
            var actual = BigNumberHelper.Multiply(v1, v2);
            CollectionAssert.AreEqual(ex, actual);
        }
        
        [TestMethod]
        public void TestMultiply3()
        {
            int[] v1 = BigNumberHelper.GetArrayFromString("1234");
            int[] v2 = BigNumberHelper.GetArrayFromString("5678");
            int[] ex = BigNumberHelper.GetArrayFromString("7006652");
            var actual = BigNumberHelper.Multiply(v1, v2);
            CollectionAssert.AreEqual(ex, actual);
        }[TestMethod]
        public void TestMultiply4()
        {
            int[] v1 = BigNumberHelper.GetArrayFromString("1234567891011121314151617181920");
            int[] v2 = BigNumberHelper.GetArrayFromString("2019181716151413121110987654321");
            int[] ex = BigNumberHelper.GetArrayFromString("2492816912877266687794240983772975935013386905490061131076320");
            var actual = BigNumberHelper.Multiply(v1, v2);
            CollectionAssert.AreEqual(ex, actual);
        }

        [TestMethod]
        public void TestMultiplyV1Empty()
        {
            int[] v1 = {};
            int[] v2 = {1, 2, 3, 4};
            int[] ex = {};
            var actual = BigNumberHelper.Multiply(v1, v2);
            CollectionAssert.AreEqual(ex, actual);
        }

        [TestMethod]
        public void TestMultiplyV2Empty()
        {
            int[] v1 = {1, 2, 3, 4};
            int[] v2 = {};
            int[] ex = {};
            var actual = BigNumberHelper.Multiply(v1, v2);
            CollectionAssert.AreEqual(ex, actual);
        }

        [TestMethod]
        public void TestMultiplyV1Null()
        {
            int[] v1 = null;
            int[] v2 = {2, 3, 4, 5};
            int[] ex = {};
            var actual = BigNumberHelper.Multiply(v1, v2);
            CollectionAssert.AreEqual(ex, actual);
        }

        [TestMethod]
        public void TestMultiplyV2Null()
        {
            int[] v1 = {1, 2, 3, 4};
            int[] v2 = null;
            int[] ex = {};
            var actual = BigNumberHelper.Multiply(v1, v2);
            CollectionAssert.AreEqual(ex, actual);
        }

        #endregion

        #region MultiplyKaratsuba

        [TestMethod]
        public void TestMultiplyKaratsuba0()
        {
            int[] v1 = BigNumberHelper.GetArrayFromString("46");
            int[] v2 = BigNumberHelper.GetArrayFromString("134");
            int[] ex = BigNumberHelper.GetArrayFromString("6164");
            var actual = BigNumberHelper.MultiplyKaratsuba(v1, v2);
            CollectionAssert.AreEqual(ex, actual);
        }

        [TestMethod]
        public void TestMultiplyKaratsuba1()
        {
            int[] v1 = BigNumberHelper.GetArrayFromString("1234");
            int[] v2 = BigNumberHelper.GetArrayFromString("5678");
            int[] ex = BigNumberHelper.GetArrayFromString("7006652");
            var actual = BigNumberHelper.MultiplyKaratsuba(v1, v2);
            CollectionAssert.AreEqual(ex, actual);
        }

        [TestMethod]
        public void TestMultiplyKaratsuba2()
        {
            int[] v1 = BigNumberHelper.GetArrayFromString("123456789");
            int[] v2 = BigNumberHelper.GetArrayFromString("8888");
            int[] ex = BigNumberHelper.GetArrayFromString("1097283940632");
            var actual = BigNumberHelper.MultiplyKaratsuba(v1, v2);
            CollectionAssert.AreEqual(ex, actual);
        }

        [TestMethod]
        public void TestMultiplyKaratsuba3()
        {
            int[] v1 = BigNumberHelper.GetArrayFromString("1234567891011121314151617181920");
            int[] v2 = BigNumberHelper.GetArrayFromString("2019181716151413121110987654321");
            int[] ex = BigNumberHelper.GetArrayFromString("2492816912877266687794240983772975935013386905490061131076320");
            var actual = BigNumberHelper.MultiplyKaratsuba(v1, v2);
            CollectionAssert.AreEqual(ex, actual);
        }

        [TestMethod]
        public void TestMultiplyKaratsubaV1Empty()
        {
            int[] v1 = {};
            int[] v2 = {1, 2, 3, 4};
            int[] ex = {};
            var actual = BigNumberHelper.MultiplyKaratsuba(v1, v2);
            CollectionAssert.AreEqual(ex, actual);
        }

        [TestMethod]
        public void TestMultiplyKaratsubaV2Empty()
        {
            int[] v1 = {1, 2, 3, 4};
            int[] v2 = {};
            int[] ex = {};
            var actual = BigNumberHelper.MultiplyKaratsuba(v1, v2);
            CollectionAssert.AreEqual(ex, actual);
        }

        [TestMethod]
        public void TestMultiplyKaratsubaV1Null()
        {
            int[] v1 = null;
            int[] v2 = {2, 3, 4, 5};
            int[] ex = {};
            var actual = BigNumberHelper.MultiplyKaratsuba(v1, v2);
            CollectionAssert.AreEqual(ex, actual);
        }

        [TestMethod]
        public void TestMultiplyKaratsubaV2Null()
        {
            int[] v1 = {1, 2, 3, 4};
            int[] v2 = null;
            int[] ex = {};
            var actual = BigNumberHelper.MultiplyKaratsuba(v1, v2);
            CollectionAssert.AreEqual(ex, actual);
        }

        #endregion

        #region Other methods and tests

        [TestMethod]
        public void TestGetArrayMultiply10PowerN()
        {
            CollectionAssert.AreEqual(new []{0,0,0,1,2,3}, BigNumberHelper.GetArrayMultiply10PowerN(new []{1, 2, 3}, 3));
        }

        [TestMethod]
        public void TestGetArrayFromNumber()
        {
            CollectionAssert.AreEqual(new []{5,4,3,2,1}, BigNumberHelper.GetArrayFromNumber(12345));
        }

        [TestMethod]
        public void TestGetNumberArrayFromString()
        {
            CollectionAssert.AreEqual(new []{5,4,3,2,1}, BigNumberHelper.GetArrayFromString("12345"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGetNumberArrayFromStringException()
        {
            CollectionAssert.AreEqual(new []{5,4,3,2,1}, BigNumberHelper.GetArrayFromString("012345"));
        }

        [TestMethod]
        public void TestMinusNumber()
        {
            int n, carry;
            (n, carry) = BigNumberHelper.MinusNumber(8, 9, 0);
            Assert.AreEqual(9, n);
            Assert.AreEqual(-1, carry);

            (n, carry) = BigNumberHelper.MinusNumber(8, 9, -1);
            Assert.AreEqual(8, n);
            Assert.AreEqual(-1, carry);
        }

        #endregion
    }
}
