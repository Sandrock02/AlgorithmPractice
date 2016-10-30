using System;
using AlgorithmPractice.MicrosoftResumeQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPracticeTest.MicrosoftResumeQuestionsTests
{
    public partial class MicrosoftResumeQuestionsTests
    {
        [TestMethod]
        public void Q014FindSpecificSumInSortedArrayTest()
        {
            var array = new[] {1, 2, 4, 7, 11, 15};
            var sumToFind = 22;

            int value1, value2;
            var result = Q014FindSpecificSumInSortedArray.FindSpecificSumInSortedArray(array, sumToFind, out value1,
                out value2);

            Assert.IsTrue(result);
            Assert.AreEqual(sumToFind, value1 + value2);

            sumToFind = 25;
            result = Q014FindSpecificSumInSortedArray.FindSpecificSumInSortedArray(array, sumToFind, out value1,
                out value2);

            Assert.IsFalse(result);

            array = new[] {-10, -7, -3, 0, 3, 5, 7, 9};
            sumToFind = 3;
            result = Q014FindSpecificSumInSortedArray.FindSpecificSumInSortedArray(array, sumToFind, out value1,
                out value2);
            Assert.IsTrue(result);
            Assert.AreEqual(sumToFind, value1 + value2);
        }
    }
}
