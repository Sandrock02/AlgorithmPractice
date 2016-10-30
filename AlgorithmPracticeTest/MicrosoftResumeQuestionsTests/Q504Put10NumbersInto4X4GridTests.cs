using System.IO;

namespace AlgorithmPracticeTest.MicrosoftResumeQuestionsTests
{
    using AlgorithmPractice.ResumeQuestions;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// MicrosoftResumeQuestions Tests
    /// </summary>
    public partial class MicrosoftResumeQuestionsTests
    {
        [TestMethod]
        public void TestQ504Put10NumbersInto4X4Grid()
        {
            var result = Q504Put10NumbersInto4X4Grid.Put10NumbersInto4X4Grid();
            Assert.AreEqual(96, result.Count);
            //using (var fs = File.OpenWrite("Output.txt"))
            //{
            //    using (var sw = new StreamWriter(fs))
            //    {
            //        foreach (var r in result)
            //        {
            //            for (int i = 0; i < r.Length; i++)
            //            {
            //                sw.Write(r[i] ? "O" : "X");
            //                if (i % 4 == 3)
            //                    sw.WriteLine();
            //            }

            //            sw.WriteLine();
            //        }
            //    }
            //}
        }
    }
}
