using System;

namespace AlgorithmPractice.Algorithms.Sort
{
    public static class QuickSort
    {
        /// <summary>
        /// Sort by ASC
        /// </summary>
        public static void Sort(int[] a, int low, int up)
        {
            if (low < up)
            {
                var i = low;
                var j = up;
                var t = a[i];
                while (i != j)
                {
                    while (i < j && a[j] > t)
                        j--;
                    if (i < j) a[i++] = a[j];
                    while (i < j && a[i] <= t)
                        i++;
                    if (i < j) a[j--] = a[i];
                }

                a[i] = t;

                Sort(a, low, i - 1);
                Sort(a, i + 1, up);
            }
        }

        /// <summary>
        /// Sort by ASC
        /// </summary>
        public static void Sort<T>(T[] a, int low, int up) 
            where T : IComparable<T>
        {
            if (low < up)
            {
                var i = low;
                var j = up;
                var t = a[low];
                while (i != j)
                {
                    while (i < j && a[j].CompareTo(t) > 0) //a[j] > t
                        j--;
                    if (i < j) a[i++] = a[j];
                    while (i < j && a[i].CompareTo(t) <= 0) //a[i] <= t
                        i++;
                    if (i < j) a[j--] = a[i];
                }

                a[i] = t;

                Sort(a, low, i - 1);
                Sort(a, i + 1, up);
            }
        }
    }
}
