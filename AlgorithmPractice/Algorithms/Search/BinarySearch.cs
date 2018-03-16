using System;

namespace AlgorithmPractice.Algorithms.Search
{
    public class BinarySearch
    {
        public static int Search(int[] a, int v)
        {
            if (a == null) throw new ArgumentNullException(nameof(a));

            var i = 0;
            var j = a.Length - 1;

            while (i <= j)
            {
                var m = i + (j - i) >> 1;
                if (v == a[m]) return m;

                if (v < a[m])
                    j = m - 1;
                else
                    i = m + 1;
            }

            return -1;
        }

        public static int Search<T>(T[] a, T v)
            where T : IComparable<T>
        {
            if (a == null) throw new ArgumentNullException(nameof(a));

            var i = 0;
            var j = a.Length - 1;

            while (i <= j)
            {
                var m = i + (j - i) >> 1;
                if (v.CompareTo(a[m]) == 0) return m;

                if (v.CompareTo(a[m]) < 0)
                    j = m - 1;
                else
                    i = m + 1;
            }

            return -1;
        }
    }
}
