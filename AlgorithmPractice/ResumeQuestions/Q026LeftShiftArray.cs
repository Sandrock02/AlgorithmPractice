/*
 * 题目描述：定义字符串的左旋转操作：把字符串前面的若干个字符移动到字符串的尾部，如把字符串abcdef左旋转2位得到字符串cdefab。
 */

namespace AlgorithmPractice.MicrosoftResumeQuestions
{
    public static class Q026LeftShiftArray
    {
        /// <summary>
        /// 向左循环位移数组。逐个位移，最暴力的方法
        /// </summary>
        /// <typeparam name="T">任意类型</typeparam>
        /// <param name="array">需要位移的数组</param>
        /// <param name="shiftLength">位移的位数</param>
        /// <returns>位移后的数组</returns>
        /// <remarks>
        /// 该算法在shiftLength > array.Length / 2 的情况下效率比shiftLength &lt; array.Length /2 的情况下差一点
        /// </remarks>
        public static T[] LeftShiftOneByOne<T>(T[] array, int shiftLength)
        {
            // 当位移位数大于或等于字符串的长度时，我们认为字符串不用位移
            if (array == null) return null;

            // 右移N位，相当于左移（总长度-右移位数）位
            shiftLength = ((shiftLength % array.Length) + array.Length) % array.Length;
            if (shiftLength == 0) return array;

            // 否则，就执行按个位移的程序
            var keeps = new T[shiftLength];
            for (int i = 0; i < shiftLength; i++)
                keeps[i] = array[i];

            for (int i = 0; i < array.Length - shiftLength; i++)
                array[i] = array[i + shiftLength];

            for (int i = 0; i < shiftLength; i++)
                array[array.Length - shiftLength + i] = keeps[i];

            return array;
        }

        /// <summary>
        /// 向左循环位移数组。
        /// </summary>
        /// <typeparam name="T">任意类型</typeparam>
        /// <param name="array">需要位移的数组</param>
        /// <param name="shiftLength">位移的位数</param>
        /// <returns>位移后的数组</returns>
        public static T[] LeftShiftByRevert<T>(T[] array, int shiftLength)
        {
            if (array == null) return null;

            // 右移N位，相当于左移（总长度-右移位数）位
            shiftLength = (shiftLength % array.Length + array.Length) % array.Length;
            if (shiftLength == 0) return array;

            CommonHelpers.Revert(array, 0, shiftLength);
            CommonHelpers.Revert(array, shiftLength, array.Length - shiftLength);
            CommonHelpers.Revert(array, 0, array.Length);
            return array;
        }

        /// <summary>
        /// 向左循环位移数组。STL的Rotate算法
        /// </summary>
        /// <typeparam name="T">任意类型</typeparam>
        /// <param name="array">需要位移的字符串</param>
        /// <param name="shiftLength">位移的位数</param>
        /// <returns>位移后的字符串</returns>
        /// <remarks>
        /// 所有序号为 (j+i *m) % n (j 表示每个循环链起始位置，i 为计数变量，m表示左旋转位数，n表示字符串长度)，
        /// 会构成一个循环链（共有gcd(n,m)个，gcd为n、m的最大公约数），每个循环链上的元素只要移动一个位置即可，
        /// 最后整个过程总共交换了n次（每一次循环链，是交换n/gcd(n,m)次，总共gcd(n,m)个循环链。所以，总共交换n次）
        /// </remarks>
        public static T[] LeftShiftByStlRotate<T>(T[] array, int shiftLength)
        {
            if (array == null) return null;

            shiftLength = (shiftLength % array.Length + array.Length) % array.Length;

            if (shiftLength == 0) return array;

            int lenOfStr = array.Length;
            int numOfGroup = CommonHelpers.GCD(lenOfStr, shiftLength);
            int elemInSub = lenOfStr / numOfGroup;

            for (int j = 0; j < numOfGroup; j++)
            //对应上面的文字描述，外循环次数j为循环链的个数，即gcd(n, shiftLength)个循环链  
            {
                T tmp = array[j];

                int i;
                for (i = 0; i < elemInSub - 1; i++)
                    //内循环次数i为，每个循环链上的元素个数，n/gcd(shiftLength,n)次  
                    array[(j + i * shiftLength) % lenOfStr] = array[(j + (i + 1) * shiftLength) % lenOfStr];
                array[(j + i * shiftLength) % lenOfStr] = tmp;
            }

            return array;
        }

    }
}
