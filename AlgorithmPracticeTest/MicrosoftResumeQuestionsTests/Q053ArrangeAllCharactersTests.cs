using System;
using AlgorithmPractice.ResumeQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPracticeTest.MicrosoftResumeQuestionsTests
{
    [TestClass]
    public class Q053ArrangeAllCharactersTests
    {
        [TestMethod]
        public void TestGetAllArranges_1()
        {
            var actual = Q053ArrangeAllCharacters.GetAllArranges("abc");
            var expect = new[] {"abc", "acb", "bac", "bca", "cab", "cba"};
            CollectionAssert.AreEquivalent(expect, actual);
        }

        [TestMethod]
        public void TestGetAllArranges_2()
        {
            var actual = Q053ArrangeAllCharacters.GetAllArranges("abcd");
            var expect = new[]
            {
                "abcd", "abdc", "acbd", "acdb", "adbc", "adcb",
                "bacd", "badc", "bcad", "bcda", "bdac", "bdca",
                "cabd", "cadb", "cbad", "cbda", "cdab", "cdba",
                "dabc", "dacb", "dbac", "dbca", "dcab", "dcba"
            };
            CollectionAssert.AreEquivalent(expect, actual);
        }

        [TestMethod]
        public void TestGetAllArranges2_1()
        {
            var actual = Q053ArrangeAllCharacters.GetAllArranges2("abc");
            var expect = new[] {"abc", "acb", "bac", "bca", "cab", "cba"};
            CollectionAssert.AreEquivalent(expect, actual);
        }

        [TestMethod]
        public void TestGetAllArranges2_2()
        {
            var actual = Q053ArrangeAllCharacters.GetAllArranges2("abcd");
            var expect = new[]
            {
                "abcd", "abdc", "acbd", "acdb", "adbc", "adcb",
                "bacd", "badc", "bcad", "bcda", "bdac", "bdca",
                "cabd", "cadb", "cbad", "cbda", "cdab", "cdba",
                "dabc", "dacb", "dbac", "dbca", "dcab", "dcba"
            };
            CollectionAssert.AreEquivalent(expect, actual);
        }
    }
}
