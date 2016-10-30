namespace AlgorithmPracticeTest.Algorithms.TreeRelated
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using AlgorithmPractice.Algorithms.TreeRelated;

    [TestClass]
    public class TreeWalkTests
    {
        [TestMethod]
        public void TestPreOrderRecursively()
        {
            var root = TreeGenerator.GetSimpleNormalTree();
            var result = TreeWalk.PreOrderWalk(root, TreeWalk.TreeWalkType.Recursively);
            var actual = string.Join(" ", result);
            var expected = "A B D E C F G";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMidOrderRecursively()
        {
            var root = TreeGenerator.GetSimpleNormalTree();
            var result = TreeWalk.MidOrderWalk(root, TreeWalk.TreeWalkType.Recursively);
            var actual = string.Join(" ", result);
            var expected = "D B E A F C G";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPostOrderRecursively()
        {
            var root = TreeGenerator.GetSimpleNormalTree();
            var result = TreeWalk.PostOrderWalk(root, TreeWalk.TreeWalkType.Recursively);
            var actual = string.Join(" ", result);
            var expected = "D E B F G C A";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPreOrderNormal()
        {
            var root = TreeGenerator.GetSimpleNormalTree();
            var result = TreeWalk.PreOrderWalk(root);
            var actual = string.Join(" ", result);
            var expected = "A B D E C F G";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMidOrderNormal()
        {
            var root = TreeGenerator.GetSimpleNormalTree();
            var result = TreeWalk.MidOrderWalk(root);
            var actual = string.Join(" ", result);
            var expected = "D B E A F C G";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPostOrderNormal()
        {
            var root = TreeGenerator.GetSimpleNormalTree();
            var result = TreeWalk.PostOrderWalk(root);
            var actual = string.Join(" ", result);
            var expected = "D E B F G C A";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLevelOrderWalk()
        {
            var root = TreeGenerator.GetSimpleNormalTree();
            var result = TreeWalk.LevelOrderWalk(root);
            var actual = string.Join(" ", result);
            var expected = "A B C D E F G";

            Assert.AreEqual(expected, actual);
        }
    }
}
