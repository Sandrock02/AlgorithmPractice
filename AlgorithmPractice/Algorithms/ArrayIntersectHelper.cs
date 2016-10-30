/*
题目描述：
假设这有一个各种字母组成的字符串A，和另外一个字符串B，字符串里B的字母数相对少一些。什么方法能最快的查出所有小字符串B里的字母在大字符串A里都有？

比如，如果是下面两个字符串：
String 1: ABCDEFGHLMNOPQRS
String 2: DCGSRQPO
答案是true，所有在string2里的字母string1也都有。
  
如果是下面两个字符串：  
String 1: ABCDEFGHLMNOPQRS   
String 2: DCGSRQPZ  
答案是false，因为第二个字符串里的Z字母不在第一个字符串里。
*/

using System;
using System.Collections.Generic;
using System.Linq;
using AlgorithmPractice.Algorithms.Sort;

namespace AlgorithmPractice.Algorithms
{
    public static class ArrayIntersectHelper
    {
        public static bool ArrayIntersectOneByOne<T>(T[] arrayA, T[] arrayB) 
            where T : IComparable<T>
        {
            if (arrayA == null || arrayB == null || arrayA.Length == 0 || arrayB.Length == 0) return false;

            foreach (var i in arrayB)
            {
                var innerResult = false;
                foreach (var j in arrayA)
                {
                    if (i.CompareTo(j) == 0)
                    {
                        innerResult = true;
                        break;
                    }
                }

                if (!innerResult) return false;
            }

            return true;
        }

        public static bool ArrayIntersectOneByOneLinq<T>(T[] arrayA, T[] arrayB) 
            where T : IComparable<T>
        {
            if (arrayA == null || arrayB == null || arrayA.Length == 0 || arrayB.Length == 0) return false;

            return arrayB.Select(i => arrayA.Any(j => i.CompareTo(j) == 0)).All(innerResult => innerResult);
        }

        public static bool ArrayIntersectSort<T>(T[] arrayA, T[] arrayB) 
            where T : IComparable<T>
        {
            if (arrayA == null || arrayB == null || arrayA.Length == 0 || arrayB.Length == 0) return false;

            QuickSort.Sort(arrayA, 0, arrayA.Length - 1);
            QuickSort.Sort(arrayB, 0, arrayB.Length - 1);

            for (int i = 0, j = 0; i < arrayA.Length && j < arrayB.Length; )
            {
                int compareResult = arrayB[j].CompareTo(arrayA[i]);
                if (compareResult > 0) i++;
                else if (compareResult < 0) return false;
                else j++;
            }

            return true;
        }

        public static bool ArrayIntersectHash<T>(T[] arrayA, T[] arrayB) where T : IComparable<T>
        {
            if (arrayA == null || arrayB == null || arrayA.Length == 0 || arrayB.Length == 0) return false;

            int count = 0;
            var hash = new HashSet<T>();
            foreach (var sub in arrayB)
            {
                if (!hash.Contains(sub))
                {
                    hash.Add(sub);
                    count++;
                }
            }

            foreach (var sub in arrayA)
            {
                if (hash.Contains(sub))
                {
                    count--;
                    hash.Remove(sub);
                }
            }

            return count == 0;
        }

        /*
         
         使用素数计算，但是需要大数乘除法。此处不列举
         
         */
        public static bool ArrayIntersectPrime<T>(T[] arrayA, T[] arrayB) where T : IComparable<T>
        {
            throw new NotImplementedException();
        }
    }
}
