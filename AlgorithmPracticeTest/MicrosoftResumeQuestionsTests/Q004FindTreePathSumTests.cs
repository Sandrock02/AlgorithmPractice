using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmPractice.Commons;
using AlgorithmPractice.ResumeQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPracticeTest.MicrosoftResumeQuestionsTests
{
    public partial class MicrosoftResumeQuestionsTests
    {
        [TestMethod]
        public void Q004FindTreePathSumTest()
        {
            var root = BinaryTreeHelper.BuildTree([10, 5, 12, 4, 7], new List<int> {0, 1, 2, 3, 4});
            var obj = new Q004FindTreePathSum();
            var paths = obj.FindTreePathSumInt32(root, 22);

            foreach (var path in paths)
            {
                Console.WriteLine(path);
            }

            var expect = new[] {"10->5->7", "10->12"};
            CollectionAssert.AreEquivalent(expect, paths);

            Console.WriteLine("==========================================");
            root = BinaryTreeHelper.BuildTree([10, 5, 12, 4, 7, 0, 0, 3], new List<int> { 0, 1, 2, 3, 4, 7 });
            paths = obj.FindTreePathSumInt32(root, 22);

            foreach (var path in paths)
            {
                Console.WriteLine(path);
            }

            expect = ["10->5->4->3", "10->5->7", "10->12"];
            CollectionAssert.AreEquivalent(expect, paths);

            Console.WriteLine("==========================================");
            root = BinaryTreeHelper.BuildTree([10, 5, 12, 4, 9, 0, 0, 3], new List<int> { 0, 1, 2, 3, 4, 7 });
            paths = obj.FindTreePathSumInt32(root, 22);

            foreach (var path in paths)
            {
                Console.WriteLine(path);
            }

            expect = ["10->5->4->3", "10->12"];
            CollectionAssert.AreEquivalent(expect, paths);
        }
    }
}
