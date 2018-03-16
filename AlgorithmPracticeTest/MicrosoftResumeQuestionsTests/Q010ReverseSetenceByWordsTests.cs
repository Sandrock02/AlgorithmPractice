using System;
using AlgorithmPractice.ResumeQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPracticeTest.MicrosoftResumeQuestionsTests
{
    public partial class MicrosoftResumeQuestionsTests
    {
        [TestMethod]
        public void Q010ReverseSetenceByWordsTest1()
        {
            const string input = "I am a student.";
            const string expected = "student. a am I";
            var actual = Q010ReverseSetenceByWords.ReverseSetenceByWords(input);
            Assert.AreEqual(expected, actual);

            actual = Q010ReverseSetenceByWords.ReverseSetenceByWordsLinq(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Q010ReverseSetenceByWordsTest2()
        {
            const string input = "I am a student.";
            const string expected = "student. a am I";

            var actual = Q010ReverseSetenceByWords.ReverseSetenceByWordsLinq(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Q010ReverseSetenceByWordsTest3()
        {
            const string input = "student";
            var actual = input.ToCharArray();
            Q010ReverseSetenceByWords
                .ReverseCharArrayAdvance(actual, 0, input.Length - 1);
            var expected = "tneduts";
            Assert.AreEqual(expected, new string(actual));
        }
    }
}
