using AlgorithmPractice.Commons;
using AlgorithmPractice.MicrosoftResumeQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPracticeTest.MicrosoftResumeQuestionsTests
{
    public partial class MicrosoftResumeQuestionsTests
    {
        private delegate bool MethodDelegate(BinaryTreeNode<int> root, BinaryTreeNode<int> n1, BinaryTreeNode<int> n2, out BinaryTreeNode<int> foundNode);

        [TestMethod]
        public void Q075FindMostCloseBinaryNodeTest1()
        {
            RunTest(Q075FindMostCloseBinaryNode.FindNode, true);
        }

        [TestMethod]
        public void Q075FindMostCloseBinaryNodeTest2()
        {
            var root = BinaryTreeHelper.BuildTree(new int[] { 5, 4, 7, 8, 9, 6, 3, 2, 1 });

            var n1 = root.LeftChild.LeftChild.LeftChild;
            var n2 = root.LeftChild.RightChild;

            var expected = root.LeftChild;
            var result = Q075FindMostCloseBinaryNode.FindNode(root, n1, n2);
            Assert.AreEqual(expected, result);

            n1 = root.LeftChild.LeftChild.LeftChild;
            n2 = root.RightChild.RightChild;
            expected = root;
            result = Q075FindMostCloseBinaryNode.FindNode(root, n1, n2);
            Assert.AreEqual(expected, result);

            n1 = root.LeftChild.LeftChild.LeftChild;
            n2 = root.RightChild.LeftChild;
            expected = root;
            result = Q075FindMostCloseBinaryNode.FindNode(root, n1, n2);
            Assert.AreEqual(expected, result);

            result = Q075FindMostCloseBinaryNode.FindNode(null, n1, n2);
            Assert.IsNull(result);

            result = Q075FindMostCloseBinaryNode.FindNode(root, null, n2);
            Assert.IsNull(result);

            result = Q075FindMostCloseBinaryNode.FindNode(root, n1, null);
            Assert.IsNull(result);

            result = Q075FindMostCloseBinaryNode.FindNode(root, n1, n1);
            Assert.IsNull(result);

            if (true)
            {
                n1 = root.LeftChild;
                n2 = root.LeftChild.LeftChild.RightChild;

                expected = root.LeftChild;
                result = Q075FindMostCloseBinaryNode.FindNode(root, n1, n2);
                Assert.AreEqual(expected, result);
            }

            if(true)
            {
                n1 = root.LeftChild;
                n2 = new BinaryTreeNode<int>(5);
                result = Q075FindMostCloseBinaryNode.FindNode(root, n1, n2);
                Assert.AreEqual(n1, result);
            }
        }

        private void RunTest(MethodDelegate function, bool testExtra)
        {
            var root = BinaryTreeHelper.BuildTree(new int[] { 5, 4, 7, 8, 9, 6, 3, 2, 1 });

            var n1 = root.LeftChild.LeftChild.LeftChild;
            var n2 = root.LeftChild.RightChild;

            var expected = root.LeftChild;
            BinaryTreeNode<int> foundNode;
            var result = function(root, n1, n2, out foundNode);
            Assert.IsTrue(result);
            Assert.AreEqual(expected, foundNode);

            n1 = root.LeftChild.LeftChild.LeftChild;
            n2 = root.RightChild.RightChild;
            expected = root;
            result = function(root, n1, n2, out foundNode);
            Assert.IsTrue(result);
            Assert.AreEqual(expected, foundNode);

            n1 = root.LeftChild.LeftChild.LeftChild;
            n2 = root.RightChild.LeftChild;
            expected = root;
            result = function(root, n1, n2, out foundNode);
            Assert.IsTrue(result);
            Assert.AreEqual(expected, foundNode);

            result = function(null, n1, n2, out foundNode);
            Assert.IsFalse(result);

            result = function(root, null, n2, out foundNode);
            Assert.IsFalse(result);

            result = function(root, n1, null, out foundNode);
            Assert.IsFalse(result);

            result = function(root, n1, n1, out foundNode);
            Assert.IsFalse(result);

            if (testExtra)
            {
                n1 = root.LeftChild;
                n2 = root.LeftChild.LeftChild.RightChild;

                expected = root.LeftChild;
                result = function(root, n1, n2, out foundNode);
                Assert.IsTrue(result);
                Assert.AreEqual(expected, foundNode);
            }

            if (testExtra)
            {
                n1 = root.LeftChild;
                n2 = new BinaryTreeNode<int>(5);
                result = function(root, n1, n2, out foundNode);
                Assert.IsTrue(result);
                Assert.IsNull(foundNode);
            }
        }
    }
}
