using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.ResumeQuestions
{
    public class Q507MatchNBrackets
    {
        public static List<string> GenerateNBracketsCombination(uint bracketPair)
        {
            HashSet<string> result = new HashSet<string>();
            if (bracketPair > 0)
            {
                Stack<char> pathStack = new Stack<char>();

                TryMatchBrackets(pathStack, '(', 1, 0, result, bracketPair);
            }

            return result.ToList();
        }

        private static void TryMatchBrackets(Stack<char> path, char cur, uint left, uint right, HashSet<string> result, uint bracketPair)
        {
            path.Push(cur);
            if (left == bracketPair && left == right)
            {
                // Finish construct the string, output the stack as result.
                var str = new string(path.Reverse().ToArray());
                if (!result.Contains(str))
                {
                    result.Add(str);
                }

                path.Pop();
                return;
            }

            if (left >= right)
            {
                if (left < bracketPair)
                {
                    TryMatchBrackets(path, '(', left + 1, right, result, bracketPair);
                }

                if (right < bracketPair)
                {
                    TryMatchBrackets(path, ')', left, right + 1, result, bracketPair);
                }
            }

            path.Pop();
        }
    }
}
