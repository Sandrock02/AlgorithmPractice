namespace AlgorithmPractice.Algorithms.Sort
{
    public class MergeSort
    {
        public static void Sort(int[] a)
        {
            MergeSorting(a, 0, a.Length - 1);
        }

        private static void MergeArray(int[] a, int first, int mid, int last)
        {
            var temp = new int[last - first + 1];
            int i = first, j = mid + 1;
            int m = mid, n = last;
            var k = 0;

            while (i <= m && j <= n)
            {
                if (a[i] <= a[j])
                    temp[k++] = a[i++];
                else
                    temp[k++] = a[j++];
            }

            while (i <= m)
                temp[k++] = a[i++];

            while (j <= n)
                temp[k++] = a[j++];

            for (i = 0; i < k; i++)
                a[first + i] = temp[i];
        }

        private static void MergeSorting(int[] a, int first, int last)
        {
            if (first < last)
            {
                var mid = first + (last - first) / 2;
                MergeSorting(a, first, mid);    //左边有序  
                MergeSorting(a, mid + 1, last); //右边有序  
                MergeArray(a, first, mid, last); //再将二个有序数列合并  
            }
        }

    }
}
