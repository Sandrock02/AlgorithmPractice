namespace AlgorithmPractice.MicrosoftResumeQuestions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Q021FindSumMFromNNumbers
    {
        public static List<string> FindSumM(int n, int m)
        {
            var array = new int[n];
            for (var i = 0; i < n; i++)
            {
                array[i] = i + 1;
            }

            if ((m <= 0) || (m > ((n * n) + n) / 2))
            {
                return new List<string>();
            }

            var output = new List<string>();
            FindRecursively(array, 0, m, new Stack<int>(), output);
            return output;
        }

        private static void FindRecursively(int[] array, int startIndex, int currentM, Stack<int> candidatePath, List<string> output)
        {
            for (var i = startIndex; i < array.Length - 1; i++)
            {
                var remain = currentM - array[i];
                if (remain < 0)
                {
                    break;
                }

                if (remain == 0)
                {
                    candidatePath.Push(array[i]);
                    output.Add(string.Join(" ", candidatePath.Reverse()));
                    candidatePath.Pop();
                }
                else if (remain >= array[i + 1])
                {
                    candidatePath.Push(array[i]);
                    FindRecursively(array, i + 1, remain, candidatePath, output);
                    candidatePath.Pop();
                }
            }
        }
    }
}
