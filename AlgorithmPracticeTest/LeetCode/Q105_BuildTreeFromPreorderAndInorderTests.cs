using System.Collections.Generic;
using AlgorithmPractice.Algorithms.TreeRelated;
using AlgorithmPractice.Commons;
using AlgorithmPractice.LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPracticeTest;

[TestClass]
public class Q105_BuildTreeFromPreorderAndInorderTests
{
    [TestMethod]
    public void TestMethod1()
    {
        var preorder = new[] { 3, 9, 20, 15, 7 };
        var inorder = new[] { 9, 3, 15, 20, 7 };

        var root = Q105_BuildTreeFromPreorderAndInorder.BuildTree(preorder, inorder);

        var list = new List<int>();
        TreeWalk.PreOrderRecursively(root, list);
        CollectionAssert.AreEqual(preorder, list);

        var list2 = new List<int>();
        TreeWalk.MidOrderRecursively(root, list2);
        CollectionAssert.AreEqual(inorder, list2);
    }

    [TestMethod]
    public void TestMethod2()
    {
        var preorder = new[] { 1, 2 };
        var inorder = new[] { 2, 1 };

        var root = Q105_BuildTreeFromPreorderAndInorder.BuildTree(preorder, inorder);

        var list = new List<int>();
        TreeWalk.PreOrderRecursively(root, list);
        CollectionAssert.AreEqual(preorder, list);

        var list2 = new List<int>();
        TreeWalk.MidOrderRecursively(root, list2);
        CollectionAssert.AreEqual(inorder, list2);
    }
}
