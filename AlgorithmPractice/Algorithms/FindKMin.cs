﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmPractice.Algorithms
{
    public class FindKMin
    {
        void HeapAdjust(int[] array, int length, int i)
        {
            // 最小堆
            int child, temp;
            for (temp = array[i]; 2 * i + 1 < length; i = child)
            {
                child = 2 * i + 1;
                if (child < length - 1 && array[child + 1] < array[child])
                    child++;

                if (temp > array[child])
                    array[i] = array[child];
                else
                    break;

                array[child] = temp;
            }
        }

        void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        int GetMin(int[] array, int length, int k)
        {
            var min = array[0];
            Swap(ref array[0], ref array[length - 1]);

            int child, temp;
            int i = 0, j = k - 1;
            for (temp = array[0]; j > 0 && 2 * i + 1 < length; --j, i = child)
            {
                child = 2 * i + 1;
                if (child < length - 1 && array[child + 1] < array[child])
                    child++;
                if (temp > array[child])
                    array[i] = array[child];
                else break;

                array[child] = temp;
            }

            return min;
        }

        public List<int> KMin(int[] array, int k)
        {
            var length = array.Length;
            for (var i = length / 2 - 1; i >= 0; --i)
                HeapAdjust(array, length, i);

            var j = length;
            var result = new List<int>();
            for (var i = k; i > 0; --i, --j)
            {
                var min = GetMin(array, j, i);
                result.Add(min);
            }

            return result;
        }

        public List<int> KMin2(int[] array, int k)
        {
            HeapHelper.BuildMaxHeap(array, k);

            for (int i = k; i < array.Length; i++)
            {
                if (array[i] < array[0])
                {
                    Swap(ref array[i], ref array[0]);
                    HeapHelper.BuildMaxHeap(array, k);
                }
            }

            return array.Take(k).ToList();
        }
    }
}
