using System.Collections.Generic;

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

            root = TreeGenerator.GetSimpleTree();
            result = TreeWalk.PreOrderWalk(root, TreeWalk.TreeWalkType.Recursively);
            actual = string.Join(" ", result);
            expected = "A B D C E G F";
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

            root = TreeGenerator.GetSimpleTree();
            result = TreeWalk.MidOrderWalk(root, TreeWalk.TreeWalkType.Recursively);
            actual = string.Join(" ", result);
            expected = "D B A G E C F";
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

            root = TreeGenerator.GetSimpleTree();
            result = TreeWalk.PostOrderWalk(root, TreeWalk.TreeWalkType.Recursively);
            actual = string.Join(" ", result);
            expected = "D B G E F C A";
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

            root = TreeGenerator.GetSimpleTree();
            result = TreeWalk.PreOrderWalk(root);
            actual = string.Join(" ", result);
            expected = "A B D C E G F";
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

            root = TreeGenerator.GetSimpleTree();
            result = TreeWalk.MidOrderWalk(root);
            actual = string.Join(" ", result);
            expected = "D B A G E C F";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMidOrderNormal2()
        {
            var root = TreeGenerator.GetSimpleNormalTree();
            var result = new List<string>();
            TreeWalk.MidOrderNormal2(root, result);
            var actual = string.Join(" ", result);
            var expected = "D B E A F C G";

            Assert.AreEqual(expected, actual);

            root = TreeGenerator.GetSimpleTree();
            result = new List<string>();
            TreeWalk.MidOrderNormal2(root, result);
            actual = string.Join(" ", result);
            expected = "D B A G E C F";
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

            root = TreeGenerator.GetSimpleTree();
            result = TreeWalk.PostOrderWalk(root);
            actual = string.Join(" ", result);
            expected = "D B G E F C A";
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
