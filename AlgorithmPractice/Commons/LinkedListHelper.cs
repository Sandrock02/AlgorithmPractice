using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Commons
{
    public static class LinkedListHelper
    {
        public static LinkedNode<T> BuildLinkedList<T>(T[] nodeValues)
            where T : IComparable<T>
        {
            if (nodeValues == null) return null;
            if (nodeValues.Length == 0) return null;

            var root = new LinkedNode<T>(nodeValues[0]);
            var current = root;
            for (int i = 1; i < nodeValues.Length; i++, current = current.Next)
            {
                current.Next = new LinkedNode<T>(nodeValues[i]);
            }

            return root;
        }

        public static LinkedNode2Way<T> BuildLinkedList2Way<T>(T[] nodeValues)
            where T : IComparable<T>
        {
            if (nodeValues == null) return null;
            if (nodeValues.Length == 0) return null;

            var root = new LinkedNode2Way<T>(nodeValues[0]);
            var current = root;
            for (int i = 1; i < nodeValues.Length; i++)
            {
                current = current.AppendNext(new LinkedNode2Way<T>(nodeValues[i]));
            }

            return root;
        }

        public static T[] GetValueArray<T>(this LinkedNode<T> head)
            where T: IComparable<T>
        {
            if (head == null) return null;
            var result = new List<T>();

            var node = head;
            while (node != null)
            {
                result.Add(node.Value);
                node = node.Next;
            }

            return result.ToArray();
        }

        /// <summary>
        /// Test if the linked list has cylic
        /// </summary>
        /// <typeparam name="T">The value type</typeparam>
        /// <param name="h1">The head of linked list</param>
        /// <returns>null if the linked list has cylic, otherwise, return one node in the cylic</returns>
        public static LinkedNode<T> TestHasCylic<T>(this LinkedNode<T> h1)
            where T : IComparable<T>
        {
            if (h1 == null) return null;

            var p1 = h1;
            var p2 = h1;

            while (p1 != null && p2 != null && p2.Next != null)
            {
                p1 = p1.Next;
                p2 = p2.Next.Next;

                if (p1 == p2) return p1;
            }

            return null;
        }
    }
}
