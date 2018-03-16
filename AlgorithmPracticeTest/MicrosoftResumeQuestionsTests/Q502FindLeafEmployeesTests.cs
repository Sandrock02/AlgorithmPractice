namespace AlgorithmPracticeTest.MicrosoftResumeQuestionsTests
{
    using AlgorithmPractice.ResumeQuestions;
    using AlgorithmPractice.OtherStructures;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public partial class MicrosoftResumeQuestionsTests
    {
        [TestMethod]
        public void Q502FindLeafEmployees_1()
        {
            var data = GetTestData();

            var result = Q502FindLeafEmployees.GetLeafNodes(data);

            Assert.AreEqual(211, result.Length);
        }

        private SelfRefObject<string>[] GetTestData()
        {
            var employees = new SelfRefObject<string>[246];
            employees [0] = new SelfRefObject<string>("Lv0");

            for (int i = 0; i < 5; i++)
            {
                employees[1 + i] = new SelfRefObject<string>("Lv1_" + i) { Parent = employees[0] };
            }

            for (int i = 0; i < 40; i++)
            {
                employees[6 + i] = new SelfRefObject<string>("LV2_" + i) { Parent = employees[1 + i % 4] };
            }

            for (int i = 0; i < 200; i++)
            {
                employees[46 + i] = new SelfRefObject<string>("LV3" + i) { Parent = employees[6 + i % 30] };
            }

            return employees;
        }
    }
}
