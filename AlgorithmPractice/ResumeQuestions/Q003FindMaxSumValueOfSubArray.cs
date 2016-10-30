namespace AlgorithmPractice.MicrosoftResumeQuestions
{
    using System;
    using System.Linq;

    /// <summary>
    /// Algorithm for get biggest sub array sum
    /// </summary>
    /// <remarks>
    /// 3.求子数组的最大和
    /// 题目：
    /// 输入一个整形数组，数组里有正数也有负数。
    /// 数组中连续的一个或多个整数组成一个子数组，每个子数组都有一个和。
    /// 求所有子数组的和的最大值。要求时间复杂度为 O(n)。
    /// 例如输入的数组为1, -2, 3, 10, -4, 7, 2, -5，和最大的子数组为3, 10, -4, 7, 2，
    /// 因此输出为该子数组的和18。
    /// </remarks>
    public static class Q003FindMaxSumValueOfSubArray
    {
        public static long FindMaxSumValueOfContinuousSubArray(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException();
            }

            if (array.Length == 0)
            {
                throw new ArgumentException("The array is empty.", "array");
            }

            long sum = 0;
            long max = long.MinValue;

            foreach (int t in array)
            {
                sum += t;
                if (sum > max)
                {
                    max = sum;
                }
                else if (sum < 0)
                {
                    sum = 0;
                }
            }

            return max;
        }

        /// <summary>
        /// Find the max sum in a array that the picked numbers are not continuously
        /// </summary>
        /// <param name="array">Input array</param>
        /// <returns>The max sum</returns>
        public static long FindMaxSumValueOfNonContinuousSubArray(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException();
            }

            if (array.Length == 0)
            {
                throw new ArgumentException("The array is empty.", "array");
            }

            // Initialize the sum result array with minimum value.
            var sums = new long[array.Length];
            for (var i = 0; i < sums.Length; i++)
            {
                sums[i] = long.MinValue;
            }

            // Scan the array to calculate the sum
            for (var i = 0; i < array.Length; i++)
            {
                sums[i] = FindNonContinuesRecursively2(array, sums, i);
            }

            // Return the last sum value
            return sums[sums.Length - 1];
        }

        /// <summary>
        /// Find the max sum for recursive
        /// </summary>
        /// <param name="array">Input array</param>
        /// <param name="sums">Sum result array</param>
        /// <param name="i">The index for current calculate number</param>
        /// <returns>The max sum</returns>
        private static long FindNonContinuesRecursively2(int[] array, long[] sums, int i)
        {
            if (sums[i] != long.MinValue)
            {
                return sums[i];
            }

            if (i == 0)
            {
                return array[0];
            }

            if (i == 1)
            {
                return Math.Max(array[0], array[1]);
            }

            // Return Max { Sum(i-1), Sum(i-2) + array[i], array[i] }
            return FindMax(
                FindNonContinuesRecursively2(array, sums, i - 1),
                FindNonContinuesRecursively2(array, sums, i - 2) + array[i],
                array[i]);
        }

        private static long FindMax(params long[] values)
        {
            return values.Max();
        }
    }
}
