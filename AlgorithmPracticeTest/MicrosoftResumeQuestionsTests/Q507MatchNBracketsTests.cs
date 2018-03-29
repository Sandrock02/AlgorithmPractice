using System;
using System.Collections.Generic;
using AlgorithmPractice.ResumeQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPracticeTest.MicrosoftResumeQuestionsTests
{
    [TestClass]
    public class Q507MatchNBracketsTests
    {
        [TestMethod]
        public void TestGenerateNBracketsCombination()
        {
            var actual = Q507MatchNBrackets.GenerateNBracketsCombination(1);
            var expect = new []{"()"};
            CollectionAssert.AreEquivalent(expect, actual);
        }

        [TestMethod]
        public void TestGenerateNBracketsCombination2()
        {
            var actual = Q507MatchNBrackets.GenerateNBracketsCombination(2);
            var expect = new[] { "()()", "(())" };
            CollectionAssert.AreEquivalent(expect, actual);
        }

        [TestMethod]
        public void TestGenerateNBracketsCombination3()
        {
            var actual = Q507MatchNBrackets.GenerateNBracketsCombination(3);
            var expect = new[] { "()()()", "()(())", "(())()", "(()())",  "((()))" };
            CollectionAssert.AreEquivalent(expect, actual);
        }

        [TestMethod]
        public void TestGenerateNBracketsCombination4()
        {
            var actual = Q507MatchNBrackets.GenerateNBracketsCombination(4);
            var expect = new[]
            {
                "()()()()", "()()(())", "()(())()", "()(()())", "()((()))",
                            "(())()()",             "(()())()", "((()))()",
                "(()()())", "(()(()))", "((())())", "((()()))", "(((())))",
                "(())(())"
            };
            PrintActual(actual);
            CollectionAssert.AreEquivalent(expect, actual);
            
        }

        private void PrintActual(List<string> result)
        {
            Console.WriteLine("=============================");
            foreach (var r in result)
            {
                Console.WriteLine(r);
            }
        }
    }
}
