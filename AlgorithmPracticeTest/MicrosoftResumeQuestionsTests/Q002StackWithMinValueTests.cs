using System;
using AlgorithmPractice.MicrosoftResumeQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPracticeTest.MicrosoftResumeQuestionsTests
{
    public partial class MicrosoftResumeQuestionsTests
    {
        [TestMethod]
        public void Q002StackWithMinValueTest()
        {
            var stack = new Q002StackWithMinValue<int>();
            stack.Push(100);
            Assert.AreEqual(100, stack.GetMinValue());
            stack.Push(20);
            Assert.AreEqual(20, stack.GetMinValue());
            stack.Push(200);
            Assert.AreEqual(20, stack.GetMinValue());
            stack.Push(10);
            Assert.AreEqual(10, stack.GetMinValue());
            stack.Pop();
            Assert.AreEqual(20, stack.GetMinValue());
        }

        [TestMethod]
        public void Q002StackWithMinValueTest_StackCapacity()
        {
            var stack = new Q002StackWithMinValue<int>(3);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Assert.AreEqual(1, stack.GetMinValue());

            stack.Push(-1);
            Assert.AreEqual(-1, stack.GetMinValue());
        }
    }
}
