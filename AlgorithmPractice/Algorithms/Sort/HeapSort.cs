using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Algorithms.Sort
{
    public class HeapSort
    {
        // 堆排序函数
        public static void Sort(int[] arr)
        {
            int length = arr.Length;

            // 构建最大堆
            for (int i = length / 2 - 1; i >= 0; i--)
            {
                AdjustHeap(arr, i, length);
            }

            // 排序过程
            for (int i = length - 1; i > 0; i--)
            {
                // 将堆顶元素（最大值）与最后一个元素交换
                (arr[i], arr[0]) = (arr[0], arr[i]);

                // 重新调整堆
                AdjustHeap(arr, 0, i);
            }
        }

        // 调整堆的函数
        private static void AdjustHeap(int[] arr, int i, int length)
        {
            int temp = arr[i]; // 保存当前节点值
            int child = 2 * i + 1; // 左子节点的索引

            while (child < length)
            {
                // 如果右子节点存在且大于左子节点
                if (child + 1 < length && arr[child] < arr[child + 1])
                {
                    child++; // 指向右子节点
                }

                // 如果当前节点大于子节点的最大值，说明已经满足最大堆性质
                if (temp >= arr[child]) break;

                // 否则，将子节点的最大值上移
                arr[i] = arr[child];
                i = child; // 更新当前节点索引
                child = 2 * i + 1; // 更新子节点索引
            }

            // 将当前节点值放到最终位置
            arr[i] = temp;
        }
    }
}
