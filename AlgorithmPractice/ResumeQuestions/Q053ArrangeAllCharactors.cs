using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmPractice.ResumeQuestions
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 题目：输入一个字符串，打印出该中的所有排列。
    /// 例如输入字符串 abc ，则输出由字符 a、b、c 所能排列出来的有字符串
    /// abc, acb, bac, bca, cab 和 cba。
    /// </remarks>
    public class Q053ArrangeAllCharactors
    {
        public static List<string> GetAllArranges(string chars)
        {
            var result = new List<string>();
            if (string.IsNullOrEmpty(chars)) return result;
            if (chars.Length == 1)
            {
                result.Add(chars);
                return result;
            }

            for (var i = 0; i < chars.Length; i++)
            {
                var next = chars.Remove(i, 1);
                var tempResult = GetAllArranges(next);
                result.AddRange(tempResult.Select(t=> chars[i] + t));
            }

            return result;
        }

        public static List<string> GetAllArranges2(string chars)
        {
            var result = new List<string>();
            RearrangeAll(chars.ToList(), "", result);
            return result;
        }

        private static void RearrangeAll(List<char> input, string prefix, List<string> result)
        {
            if (input.Count == 1)
            {
                result.Add(prefix + input[0]);
                return;
            }

            for (var i = 0; i < input.Count; i++)
            {
                var newInput = input.ToList();
                newInput.RemoveAt(i);
                RearrangeAll(newInput, prefix + input[i], result);
            }
        }
    }
}
