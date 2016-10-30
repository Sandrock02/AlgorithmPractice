using System;
using AlgorithmPractice.Algorithms.StringMatch;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPracticeTest.Algorithms.StringMatch
{
    [TestClass]
    public class KMPTests
    {
        [TestMethod]
        public void TestKMP()
        {
            string t = "thenelseturnfathereturn";
            string p = "return";

            var flink = KMPMatch.FailLink(p);
            foreach (var i in flink)
                Console.Write(i);
            Console.WriteLine();
            
            var result = KMPMatch.KmpMatch(t, p);
            Assert.AreEqual(17, result);

            t = "aaaabcde";
            p = "aaabc";

            flink = KMPMatch.FailLink(p);
            foreach (var i in flink)
                Console.Write(i);
            Console.WriteLine();

            result = KMPMatch.KmpMatch(t, p);
            Assert.AreEqual(1, result);
        }
    }
}
