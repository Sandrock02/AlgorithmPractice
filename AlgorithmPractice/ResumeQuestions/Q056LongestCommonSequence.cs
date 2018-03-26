using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmPractice.Commons;

namespace AlgorithmPractice.ResumeQuestions
{
    /// <summary>
    /// LCS
    /// </summary>
    /// <remarks>
    /// 题目：如果字符串一的所有字符按其在串中的顺序出现另外一个字符串二，则字符串一称之为字符串二的子串。
    /// 注意，并不要求子串（字符串一）的字符必须连续出现在字符串二中。
    /// 请编写一个函数，输入两字符串求它们的最长公共子并打印出。
    /// 例如：输入两个字符串 BDCABA 和 ABCBDAB，字符串BCBA 和 BDAB 都是它们的最长公共子串，则输出它们的度 4，并打印任意一个子串
    /// </remarks>
    public static class Q056LongestCommonSequence
    {
        public static string LCS(string x, string y)
        {
            int[,] opt = new int[x.Length + 1, y.Length + 1];
            int i, j;
            for (i = x.Length - 1; i >= 0; i--)
            {
                for (j = y.Length - 1; j >= 0; j--)
                {
                    if (x[i] == y[j])
                    {
                        opt[i, j] = opt[i + 1, j + 1] + 1;
                    }
                    else
                    {
                        opt[i, j] = MathHelper.Max(opt[i + 1, j], opt[i, j + 1]);
                    }
                }
            }

            var result = new StringBuilder(MathHelper.Min(x.Length, y.Length));
            i = 0;
            j = 0;
            while (i < x.Length && j < y.Length)
            {
                if (x[i] == y[j])
                {
                    result.Append(x[i]);
                    i++;
                    j++;
                }
                else if (opt[i + 1, j] >= opt[i, j + 1]) i++;
                else j++;
            }

            return result.ToString();
        }

        //public static string LCS(string x, string y)
        //{
        //    var L = new int[x.Length, y.Length];
        //    for (var k = 1; k < x.Length; k++)
        //    {
        //        for (var i = 1; i <= x.Length; i++)
        //        {
        //            if (i < k) L[k, i] = int.MaxValue;
        //            if (L[k, i] == k)
        //            {
        //                for (var l = i + 1; l <= x.Length; l++)
        //                {
        //                    L[k, l] = k;
        //                    break;
        //                }
        //            }

        //            for (var j = 1; j <= y.Length; j++)
        //            {
        //                if (x[i + 1] == y[j] && j > L[k - 1, i])
        //                {
        //                    L[k, i + 1] = (j < L[k, i] ? j : L[k, i]);
        //                    break;
        //                }

        //                if (L[k,i + 1] == 0)
        //                    L[k,i] = int.MaxValue;
        //            }

        //            if (L[k,x.Length] == int.MaxValue) {
        //                p = k - 1;
        //                break;
        //            }
        //        }
        //    }
        //}
    }
}
