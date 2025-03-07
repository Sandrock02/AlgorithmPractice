using AlgorithmPractice.LeetCode;
using AlgorithmPracticeTest.LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class Q189_ShiftArrayRightTests
{
    [TestMethod]
    public void TestMethod1()
    {
        var nums = new[] { 1, 2, 3 };
        var k = 4;

        Q189_ShiftArrayRight.Rotate(nums, k);
        CollectionAssert.AreEqual(new[]{3,1,2}, nums);
    }
}
