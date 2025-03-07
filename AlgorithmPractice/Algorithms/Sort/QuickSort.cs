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
                // 初始，i，j，分别指向数组的开头和结尾元素
                var i = low;
                var j = up;
                // 缓存 a[i]的元素到t
                var t = a[i];
                while (i != j)
                {
                    while (i < j && a[j] > t)
                    {
                        j--;
                    }
                    // 此处while的退出条件有两个，我们只关心第二个，
                    // 所以第一个条件需要再判断，此时交换a[j]到i的位置
                    if (i < j) a[i++] = a[j];

                    while (i < j && a[i] <= t)
                    {
                        i++;
                    }
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
