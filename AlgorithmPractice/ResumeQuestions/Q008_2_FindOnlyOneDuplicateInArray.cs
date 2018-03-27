using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AlgorithmPractice.ResumeQuestions
{
    public static class Q008_2_FindOnlyOneDuplicateInArray
    {
        public static int FindDuplicate(int[] array)
        {
            if (array == null) throw new ArgumentNullException(nameof(array));
            int k = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                k ^= i^array[i];
            }

            return k;
        }
    }
}