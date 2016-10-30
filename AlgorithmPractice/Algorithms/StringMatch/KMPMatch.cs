namespace AlgorithmPractice.Algorithms.StringMatch
{
    public class KMPMatch
    {
        public static int KmpMatch(string t, string p)
        {
            var n = t.Length;
            var m = p.Length;
            var i = 0;
            var j = 0;
            var flink = FailLink(p);

            while (i < n)
            {
                while (j != -1 && p[j] != t[i])
                    j = flink[j];

                if (j == m - 1) return (i - m + 1);
                i++;
                j++;
            }

            return -1;
        }

        public static int[] FailLink(string p)
        {
            var flink = new int[p.Length];

            flink[0] = -1;
            var j = 1;

            while (j < p.Length)
            {
                var k = flink[j - 1];
                while (k != -1 && p[k] != p[j - 1])
                    k = flink[k];
                flink[j] = k + 1;
                j++;
            }

            return flink;
        }
    }
}
