namespace AlgorithmPractice.MicrosoftResumeQuestions
{
    /* 
     * Find smallest positive missing integer from an array
     * The array may contains positive or negetive integers which are not sorted
     * Example: 
     *  -1, -2, 1, 2, 3 | return 4
     *  0, 1, 3, 4, return 2
     */


    public class Q503FindSmallestPositiveMissingInteger
    {
        public static int FindMissingValue(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return 1;
            }

            for (int i = 0; i < array.Length; i++)
            {
                var value = array[i];
                while (value > 0 && value <= array.Length)
                {
                    var temp = i != (value - 1) ? array[value - 1] : int.MinValue;
                    array[value - 1] = int.MinValue;
                    value = temp;
                }
            }

            int j;
            for (j = 0; j < array.Length; j++)
            {
                if (array[j] != int.MinValue)
                {
                    return j + 1;
                }
            }

            return j + 1;
        }
    }
}
