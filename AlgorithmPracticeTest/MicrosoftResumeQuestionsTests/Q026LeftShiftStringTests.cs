using System;
using AlgorithmPractice.ResumeQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPracticeTest.MicrosoftResumeQuestionsTests
{
    public partial class MicrosoftResumeQuestionsTests
    {
        [TestMethod]
        public void Q026TestLeftShiftOneByOne()
        {
            TestLeftShift(Q026LeftShiftArray.LeftShiftOneByOne);
        }

        [TestMethod]
        public void Q026TestLeftShiftByStlRotate()
        {
            TestLeftShift(Q026LeftShiftArray.LeftShiftByStlRotate);
        }

        [TestMethod]
        public void Q026TestLeftShiftByRevert()
        {
            TestLeftShift(Q026LeftShiftArray.LeftShiftByRevert);
        }

        private void TestLeftShift(Func<char[], int, char[]> leftShiftAlgorithm)
        {
            const string source = "abcdefghijkl";

            // Test 1: source length < shift length
            string expected = "cdefghijklab";

            var actual = leftShiftAlgorithm(source.ToCharArray(), 14);
            Assert.AreEqual(expected, new string(actual));

            // Test 2: source length = shift length
            expected = "abcdefghijkl";
            actual = leftShiftAlgorithm(source.ToCharArray(), source.Length);
            Assert.AreEqual(expected, new string(actual));

            // Test 3: source length > shift length
            expected = "defghijklabc";
            actual = leftShiftAlgorithm(source.ToCharArray(), 3);
            Assert.AreEqual(expected, new string(actual));

            expected = "labcdefghijk";
            actual = leftShiftAlgorithm(source.ToCharArray(), source.Length - 1);
            Assert.AreEqual(expected, new string(actual));

            // Test 4: source is null
            actual = leftShiftAlgorithm(null, 3);
            Assert.IsNull(actual);

            // Test 5: shift length = 0
            expected = "abcdefghijkl";
            actual = leftShiftAlgorithm(source.ToCharArray(), 0);
            Assert.AreEqual(expected, new string(actual));

            // Test 6: shift length < 0
            expected = "jklabcdefghi";
            actual = leftShiftAlgorithm(source.ToCharArray(), -3);
            Assert.AreEqual(expected, new string(actual));

            expected = "jklabcdefghi";
            actual = leftShiftAlgorithm(source.ToCharArray(), -15);
            Assert.AreEqual(expected, new string(actual));
        }
    }
}
