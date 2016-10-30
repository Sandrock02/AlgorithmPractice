using System;
using System.Linq;

namespace AlgorithmPractice
{
    public static class CommonHelpers
    {
        /// <summary>
        /// 求两个数的最大公约数
        /// </summary>
        /// <param name="m">较大数</param>
        /// <param name="n">较小数</param>
        /// <returns>最大公约数</returns>
        public static int GCD(int m, int n)
        {
            if (m < 0 || n < 0)
                throw new ArgumentException("m and n should be equal or greater than 0");

            // 1、[求余数]，令r=m%n，r为n除m所得余数（0<=r<n）；
            // 2、[余数为0?]，若r=0，算法结束，此刻，n即为所求答案，否则，继续，转到3；
            // 3、[重置]，置m<-n，n<-r，返回步骤1.
            do
            {
                int r = m % n;
                if (r == 0) return n;

                m = n;
                n = r;
            } while (true);
        }

        /// <summary>
        /// 逆转数组元素
        /// </summary>
        /// <typeparam name="T">数组类型</typeparam>
        /// <param name="array">需要逆转的数组</param>
        /// <param name="startIndex">开始索引</param>
        /// <param name="length">逆转的长度</param>
        public static void Revert<T>(T[] array, int startIndex, int length)
        {
            if (array == null)
                throw new ArgumentNullException("array");

            if (startIndex < 0)
                throw new ArgumentOutOfRangeException("startIndex");

            if (length < 0)
                throw new ArgumentOutOfRangeException("length");

            if (startIndex + length > array.Length)
                throw new ArgumentException("startIndex + length should be smaller than array.Length");

            var endIndex = startIndex + length - 1;

            while (startIndex < endIndex)
            {
                T temp = array[startIndex];
                array[startIndex] = array[endIndex];
                array[endIndex] = temp;

                startIndex++;
                endIndex--;
            }
        }

        public static T FindMax<T>(params T[] values)
        {
            return values.Max();
        }
    }
}
