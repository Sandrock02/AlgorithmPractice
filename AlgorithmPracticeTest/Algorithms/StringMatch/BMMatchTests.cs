using AlgorithmPractice.Algorithms.StringMatch;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPracticeTest.Algorithms.StringMatch
{
    [TestClass]
    public class BMMatchTests
    {
        [TestMethod]
        public void TestBMMatch()
        {
            const string t = "thenelseturnfathereturn";
            const string p = "return";

            int result = BMMatch.BmMatch(t, p);

            Assert.AreEqual(17, result);
        }

        [TestMethod]
        public void TestBMMapMatch()
        {
            const string t = "thenelseturnfathereturn";
            const string p = "return";

            int result = BMMatch.BmMapMatch(t, p);

            Assert.AreEqual(17, result);
        }
    }
}