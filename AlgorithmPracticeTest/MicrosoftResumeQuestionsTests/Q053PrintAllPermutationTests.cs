using System;
using AlgorithmPractice.MicrosoftResumeQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPracticeTest.MicrosoftResumeQuestionsTests
{
    public partial class MicrosoftResumeQuestionsTests
    {
        [TestMethod]
        public void Q053PrintAllPermutationTest()
        {
            var testObj = new Q053PrintAllPermutation();
            var actual = testObj.PrintAllPermutation("abc".ToCharArray());
            var expected = new[] {"abc", "acb", "bac", "bca", "cab", "cba"};
            CollectionAssert.AreEquivalent(expected, actual);

            actual = testObj.PrintAllPermutation("abcd".ToCharArray());
            expected = new[]
                           {
                               "abcd", "abdc", "acbd", "acdb", "adbc", "adcb",
                               "bacd", "badc", "bcad", "bcda", "bdac", "bdca",
                               "cabd", "cadb", "cbad", "cbda", "cdab", "cdba",
                               "dabc", "dacb", "dbac", "dbca", "dcab", "dcba"
                           };
            CollectionAssert.AreEquivalent(expected, actual);
        }
    }
}
