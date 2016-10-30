using System.Collections.Generic;

namespace AlgorithmPractice.Algorithms.StringMatch
{
    public class BMMatch
    {
        public static int BmMatch(string t, string p)
        {
            var n = t.Length;
            var m = p.Length;
            var i = m - 1;
            var d = Df(p);

            do
            {
                var j = m - 1;
                var k = i;
                while (j >= 0 && p[j] == t[k])
                {
                    j--;
                    k--;
                }

                if (j < 0) return (i - m + 1);

                i = i + d[t[i] - 'a'];

            } while (i < n);

            return -1;
        }

        private static int[] Df(string p)
        {
            var m = p.Length;
            var d = new int[26];

            for (int i = 0; i < 26; i++)
                d[i] = m;

            for (int i = 0; i < m - 1; i++)
                d[p[i] - 'a'] = m - i - 1;

            return d;
        }

        public static int BmMapMatch(string t, string p)
        {
            var n = t.Length;
            var m = p.Length;
            var i = m - 1;
            var d = DfMap(p);

            do
            {
                var j = m - 1;
                var k = i;
                while (j >= 0 && p[j] == t[k])
                {
                    j--;
                    k--;
                }

                if (j < 0) return (i - m + 1); // 找到匹配值

                //i = i + d[t[i] - 'a'];
                i = i + (d.ContainsKey(t[i]) ? d[t[i]] : m); // 计算移动位数

            } while (i < n);

            return -1;
        }

        private static Dictionary<char, int> DfMap(string p)
        {
            var m = p.Length;
            var d = new Dictionary<char, int>();

            for (var i = 0; i < m - 1; i++)
            {
                if (!d.ContainsKey(p[i]))
                    d.Add(p[i], m);

                d[p[i]] = m - i - 1;
            }

            return d;
        }
    }
}
