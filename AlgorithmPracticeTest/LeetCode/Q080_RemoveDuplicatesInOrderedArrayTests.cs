using System;
using System.Linq;
using AlgorithmPractice.LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPracticeTest;

[TestClass]
public class Q080_RemoveDuplicatesInOrderedArrayTests
{
    [TestMethod]
    public void TestMethod1()
    {
        var nums = new int[]{ 1, 1, 1, 2, 2, 3};
        var length = Q080_RemoveDuplicatesInOrderedArray.RemoveDuplicates(nums);

        Assert.AreEqual(5, length);
        CollectionAssert.AreEqual(new int[]{1,1,2,2,3}, nums.Take(length).ToArray());
    }

    [TestMethod]
    public void TestMethod2()
    {
        var nums = new int[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 };
        var length = Q080_RemoveDuplicatesInOrderedArray.RemoveDuplicates(nums);

        Assert.AreEqual(7, length);
        CollectionAssert.AreEqual(new int[] { 0, 0, 1, 1, 2, 3, 3 }, nums.Take(length).ToArray());
    }
}
