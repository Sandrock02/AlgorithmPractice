namespace AlgorithmPractice.Algorithms.Sort
{
    public class BubbleSort
    {
        public static void Sort(int[] a)
        {
            var n = a.Length - 1;

            while (n > 0)
            {
                var j = 0;
                for (var i = 0; i < n; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        var t = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = t;
                        j = i;
                    }
                }
                n = j;
            }
        }
    }
}
