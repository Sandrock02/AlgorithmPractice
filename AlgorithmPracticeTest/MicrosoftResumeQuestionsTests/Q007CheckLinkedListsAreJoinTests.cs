using AlgorithmPractice.Commons;
using AlgorithmPractice.MicrosoftResumeQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPracticeTest.MicrosoftResumeQuestionsTests
{
    public partial class MicrosoftResumeQuestionsTests
    {
        [TestMethod]
        public void Q007CheckLinkedListsAreJoinTest()
        {
            var j = new LinkedNode<int>(10,
                        new LinkedNode<int>(11,
                            new LinkedNode<int>(12)));

            var h1 = new LinkedNode<int>(1,
                        new LinkedNode<int>(2,
                            new LinkedNode<int>(3, j)));
            var h2 = new LinkedNode<int>(6, j);

            var actual = Q007CheckLinkedListsAreJoin.AreJoin(h1, h2);
            Assert.IsTrue(actual);

            var h3 = new LinkedNode<int>(7,
                        new LinkedNode<int>(8,
                            new LinkedNode<int>(9,
                                new LinkedNode<int>(10))));

            actual = Q007CheckLinkedListsAreJoin.AreJoin(h1, h3);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Q007CheckLinkedListsAreJoinHasCylicTest1()
        {
            // Create a cylic link;
            var cStart = new LinkedNode<int>(1);
            var l = cStart
                .Append(new LinkedNode<int>(2))
                .Append(new LinkedNode<int>(3))
                .Append(new LinkedNode<int>(4))
                .Append(new LinkedNode<int>(5))
                .Append(new LinkedNode<int>(6))
                .Append(new LinkedNode<int>(7))
                .Append(new LinkedNode<int>(8))
                .Append(new LinkedNode<int>(9));
            l.Next = cStart;

            // Create h1
            var h1 = new LinkedNode<int>(100, new LinkedNode<int>(101));
            h1.Next.Next = cStart;

            // Create h2
            var h2 = new LinkedNode<int>(200, 
                new LinkedNode<int>(201,
                    new LinkedNode<int>(202,
                        new LinkedNode<int>(203))));
            h2.Next.Next.Next.Next = cStart;

            var actual = Q007CheckLinkedListsAreJoin.AreJoinWithCylic(h1, h2);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void Q007CheckLinkedListsAreJoinHasCylicTest2()
        {
            // Create a cylic link;
            var cStart1 = new LinkedNode<int>(1);
            var l1 = cStart1
                .Append(new LinkedNode<int>(2))
                .Append(new LinkedNode<int>(3))
                .Append(new LinkedNode<int>(4))
                .Append(new LinkedNode<int>(5))
                .Append(new LinkedNode<int>(6))
                .Append(new LinkedNode<int>(7))
                .Append(new LinkedNode<int>(8))
                .Append(new LinkedNode<int>(9));
            l1.Next = cStart1;

            // Create a cylic link2
            var cStart2 = new LinkedNode<int>(11);
            var l2 = cStart2
                .Append(new LinkedNode<int>(12))
                .Append(new LinkedNode<int>(13))
                .Append(new LinkedNode<int>(14))
                .Append(new LinkedNode<int>(15))
                .Append(new LinkedNode<int>(16))
                .Append(new LinkedNode<int>(17))
                .Append(new LinkedNode<int>(18))
                .Append(new LinkedNode<int>(19));
            l2.Next = cStart2;

            var h1 = new LinkedNode<int>(100, new LinkedNode<int>(101));
            h1.Next.Next = cStart1;

            var h2 = new LinkedNode<int>(200,
                new LinkedNode<int>(201,
                    new LinkedNode<int>(202,
                        new LinkedNode<int>(203))));

            h2.Next.Next.Next.Next = cStart2;

            var actual = Q007CheckLinkedListsAreJoin.AreJoinWithCylic(h1, h2);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Q007CheckLinkedListsAreJoinHasCylicTest3()
        {
            var l1 = new LinkedNode<int>(1, new LinkedNode<int>(2));
            var result = l1.TestHasCylic();
            Assert.IsNull(result);

            l1 = new LinkedNode<int>(1);
            result = l1.TestHasCylic();
            Assert.IsNull(result);
        }
    }
}
