using System.Linq;
using AlgorithmPractice.LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPracticeTest;

[TestClass]
public class Q068_AlignTextLeftAndRightTests
{
    [TestMethod]
    public void TestMethod1()
    {
        var words = new string[]
        {
            "Science", "is", "what", "we", "understand", "well", "enough", "to", "explain", "to", "a", "computer.",
            "Art", "is", "everything", "else", "we", "do"
        };
        var maxWidth = 20;

        var expected = new string[]
        {
            "Science  is  what we",
            "understand      well",
            "enough to explain to",
            "a  computer.  Art is",
            "everything  else  we",
            "do                  "
        }.ToList();

        var result = Q068_AlignTextLeftAndRight.FullJustify(words, maxWidth);
        CollectionAssert.AreEqual(expected, result.ToList());
    }

    [TestMethod]
    public void TestMethod2()
    {
        var words = new[]
        {
            "What", "must", "be", "acknowledgment", "shall", "be"
        };
        var maxWidth = 16;

        var expected = new string[]
        {
            "What   must   be",
            "acknowledgment  ",
            "shall be        ",
        }.ToList();

        var result = Q068_AlignTextLeftAndRight.FullJustify(words, maxWidth);
        CollectionAssert.AreEqual(expected, result.ToList());
    }
}
