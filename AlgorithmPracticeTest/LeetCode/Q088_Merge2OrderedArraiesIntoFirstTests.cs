using AlgorithmPractice.LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPracticeTest;

[TestClass]
public class Q088_Merge2OrderedArraiesIntoFirstTests
{
    [TestMethod]
    public void TestMethod1()
    {
        var nums1 = new[] { 4, 0, 0, 0, 0, 0 };
        var nums2 = new[] { 1, 2, 3, 5, 6 };

        var m = 1;
        var n = 5;

        Q088_Merge2OrderedArraiesIntoFirst.Merge(nums1, m, nums2, n);
        CollectionAssert.AreEqual(new[]{1,2,3,4,5,6}, nums1);
    }
}
