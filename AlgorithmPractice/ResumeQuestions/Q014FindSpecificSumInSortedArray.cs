using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.ResumeQuestions
{
    /// <summary>
    /// Q014 Find Specific Sum In Sorted Array
    /// </summary>
    /// <remarks>
    /// Q014
    /// 题目：输入一个已经按升序排序过的数组和一个数字，
    /// 在数组中查找两个数，使得它们的和正好是输入的那个数字。
    /// 要求时间复杂度是 O(n)。如果有多对数字的和等于输入的数字，输出任意一对即可。
    /// 例如输入数组1、2、4、7、11、15 和数字15。由于4+11=15，因此输出4 和11。
    /// </remarks>
    public static class Q014FindSpecificSumInSortedArray
    {
        public static bool FindSpecificSumInSortedArray(int[] array, int sumToFind, out int value1, out int value2)
        {
            if (array == null || array.Length == 1)
            {
                value1 = 0;
                value2 = 0;
                return false;
            }

            var lIndex = 0;
            var rIndex = array.Length - 1;

            while (lIndex < rIndex)
            {
                if (array[lIndex] + array[rIndex] > sumToFind)
                    rIndex--;
                else if (array[lIndex] + array[rIndex] < sumToFind)
                    lIndex++;
                else
                {
                    value1 = array[lIndex];
                    value2 = array[rIndex];
                    return true;
                }
            }

            value1 = 0;
            value2 = 0;
            return false;
        }
    }
}
