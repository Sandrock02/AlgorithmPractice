using System;
using AlgorithmPractice.ResumeQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPracticeTest.MicrosoftResumeQuestionsTests
{
    [TestClass]
    public class Q506SimulateQueueWith2StacksTests
    {
        [TestMethod]
        public void TestSimulatedQueue1()
        {
            var queue = new SimulatedQueue<int>();
            queue.Enqueue(2);
            queue.Enqueue(4);
            queue.Enqueue(6);
            queue.Enqueue(8);
            queue.Enqueue(0);

            Assert.AreEqual(2, queue.Dequeue());
            Assert.AreEqual(4, queue.Dequeue());
            Assert.AreEqual(6, queue.Dequeue());
            Assert.AreEqual(8, queue.Dequeue());
            Assert.AreEqual(0, queue.Dequeue());
        }
    }
}
