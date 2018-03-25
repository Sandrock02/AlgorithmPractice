using System;

namespace AlgorithmPractice.Algorithms
{
    public static class HeapHelper
    {
        public static void BuildMaxHeap<T>(T[] array, int heapSize = 0)
            where T : IComparable<T>
        {
            if (array == null || heapSize < 0) return;
            if (heapSize == 0) heapSize = array.Length;

            for (int i = heapSize / 2 - 1; i >= 0; --i)
            {
                HeapAdjust(array, i, heapSize, (v1, v2) => v1.CompareTo(v2) > 0);
            }
        }

        public static void BuildMinHeap<T>(T[] array, int heapSize = 0)
            where T : IComparable<T>
        {
            if (array == null || heapSize < 0) return;
            if (heapSize == 0) heapSize = array.Length;

            for (int i = heapSize / 2 - 1; i >= 0; --i)
            {
                HeapAdjust(array, i, heapSize, (v1, v2) => v1.CompareTo(v2) < 0);
            }
        }

        private static void HeapAdjust<T>(T[] array, int i, int heapSize, Func<T, T, bool> func)
            where T : IComparable<T>
        {
            T temp;
            int child;
            for (temp = array[i]; i * 2 + 1 < heapSize; i = child)
            {
                child = i * 2 + 1;
                if (child < heapSize - 1 && // 左子结点未超 边界-1。换言之，右子节点也未超边界
                    func(array[child + 1], array[child])) // 如果右子节点比左子结点大
                    child++; // 则指向这个大的节点

                if (func(array[child], temp)) // 若当前节点比它的最大的子节点要小，
                    array[i] = array[child]; // 则交换两者位置
                else break; // 否则就退出循环

                array[child] = temp;
            }
        }
    }
}
