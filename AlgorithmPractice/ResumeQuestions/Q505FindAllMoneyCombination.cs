namespace AlgorithmPractice.ResumeQuestions
{
    using System.Collections.Generic;
    using System.Linq;

    public static class Q505FindAllMoneyCombination
    {
        private static readonly int[] Amounts = { 100, 50, 20, 10, 5, 1 };

        public static List<string> FindAllMoneyCombination(int targetMoney, int totalUnit)
        {
            var results = new List<int>();
            for (int i = 1; i <= 6; i++)
            {
                Dfs(i, targetMoney, totalUnit, 0, results);
            }

            var distinctResults = results.Select(Display).Distinct().ToList();
            return distinctResults;
        }

        private static void Dfs(int cur, int remainAmount, int totalUnit, int usedUnit, List<int> results)
        {
            var amount = Amounts[(cur - 1) % 6];
            var newRemain = remainAmount - amount;
            var newUsed = usedUnit + 1;
            if (usedUnit > totalUnit - 1 || newRemain < 0)
            {
                return;
            }

            if (newRemain == 0 && newUsed == totalUnit)
            {
                results.Add(cur);
                return;
            }

            for (var i = cur % 6; i <= 6; i++)
            {

                Dfs((cur * 6) + i, newRemain, totalUnit, newUsed, results);
            }
        }

        private static string Display(int i)
        {
            var dic = new Dictionary<int, int>();
            for (var index = i; index > 0; index = (index - 1) / 6)
            {
                var amount = Amounts[(index - 1) % 6];
                if (dic.ContainsKey(amount))
                {
                    dic[amount]++;
                }
                else
                {
                    dic.Add(amount, 1);
                }
            }

            var strs = Amounts.Select(
                t =>
                    {
                        if (dic.ContainsKey(t))
                        {
                            return new Summary { Amount = t, Count = dic[t] };
                        }

                        return null;
                    }).Where(t => t != null).Select(t => t.ToString());

            return string.Join(" | ", strs);
        }

        internal class Summary
        {
            public int Amount { get; set; }
            public int Count { get; set; }

            public override string ToString()
            {
                return $"{this.Amount} x {this.Count}";
            }
        }
    }
}
