namespace AlgorithmPractice.Algorithms.Sort
{
    public class BubbleSort
    {
        public static void Sort(int[] a)
        {
            var n = a.Length - 1;

            while (n > 0)
            {
                var j = 0; // Temp variable to store the last swapped index.
                for (var i = 0; i < n; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        (a[i], a[i + 1]) = (a[i + 1], a[i]);
                        j = i;
                    }
                }
                n = j; // Skip to the swapped index to check further.
            }
        }
    }
}
