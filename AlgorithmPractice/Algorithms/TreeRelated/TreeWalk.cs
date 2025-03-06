namespace AlgorithmPractice.Algorithms.TreeRelated
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using AlgorithmPractice.Commons;

    public static class TreeWalk
    {
        public enum TreeWalkType
        {
            Normal,
            Recursively
        }

        public static List<T> PreOrderWalk<T>(BinaryTreeNode<T> tree, TreeWalkType treeWalkType = TreeWalkType.Normal) where T : IComparable<T>
        {
            var output = new List<T>();

            if (TreeWalkType.Normal == treeWalkType)
            {
                PreOrderNormal(tree, output);
            }
            else
            {
                PreOrderRecursively(tree, output);
            }

            return output;
        }

        public static List<T> MidOrderWalk<T>(BinaryTreeNode<T> tree, TreeWalkType treeWalkType = TreeWalkType.Normal) where T : IComparable<T>
        {
            var output = new List<T>();

            if (TreeWalkType.Normal == treeWalkType)
            {
                MidOrderNormal2(tree, output);
            }
            else
            {
                MidOrderRecursively(tree, output);
            }

            return output;
        }

        public static List<T> PostOrderWalk<T>(BinaryTreeNode<T> tree, TreeWalkType treeWalkType = TreeWalkType.Normal) where T : IComparable<T>
        {
            IEnumerable<T> output;

            if (TreeWalkType.Normal == treeWalkType)
            {
                var p = new Stack<T>();
                PostOrderNormal(tree, p);
                output = p;
            }
            else
            {
                var p = new List<T>();
                PostOrderRecursively(tree, p);
                output = p;
            }

            return output.ToList();
        }

        public static List<T> LevelOrderWalk<T>(BinaryTreeNode<T> tree) where T : IComparable<T>
        {
            var queue = new Queue<BinaryTreeNode<T>>();
            var result = new List<T>();

            queue.Enqueue(tree);
            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                if (node == null)
                {
                    continue;
                }

                result.Add(node.Value);
                queue.Enqueue(node.LeftChild);
                queue.Enqueue(node.RightChild);
            }

            return result;
        } 

        public static void PreOrderNormal<T>(BinaryTreeNode<T> tree, List<T> output) where T : IComparable<T>
        {
            var stack = new Stack<BinaryTreeNode<T>>();
            stack.Push(tree);

            while (stack.Count > 0)
            {
                var node = stack.Pop();
                if (node == null)
                {
                    continue;
                }

                output.Add(node.Value);
                stack.Push(node.RightChild);
                stack.Push(node.LeftChild);
            }
        }

        public static void MidOrderNormal<T>(BinaryTreeNode<T> tree, List<T> output) where T : IComparable<T>
        {
            if (tree == null)
            {
                return;
            }

            var stack = new Stack<BinaryTreeNode<T>>();
            stack.Push(tree);

            var node = tree;
            while (node.LeftChild != null)
            {
                node = node.LeftChild;
                stack.Push(node);
            }

            while (stack.Count > 0)
            {
                var p = stack.Pop();
                if (p == null)
                {
                    continue;
                }

                output.Add(p.Value);
                if (p.RightChild != null)
                {
                    var r = p.RightChild;
                    stack.Push(r);
                    while (r.LeftChild != null)
                    {
                        r = r.LeftChild;
                        stack.Push(r);
                    }
                }
            }
        }

        public static void MidOrderNormal2<T>(BinaryTreeNode<T> tree, List<T> output) where T : IComparable<T>
        {
            var stack = new Stack<BinaryTreeNode<T>>();
            var node = tree;
            while (node != null || stack.Count > 0)
            {
                // 先将当前节点的所有左子节点压入栈
                while (node != null)
                {
                    stack.Push(node);
                    node = node.LeftChild;
                }

                // 弹出栈顶节点并访问
                if (stack.Count > 0)
                {
                    node = stack.Pop();
                    output.Add(node.Value);
                    // 转向右子树
                    node = node.RightChild;
                }
            }
        }

        public static void PostOrderNormal<T>(BinaryTreeNode<T> tree, Stack<T> output) where T : IComparable<T>
        {
            var stack = new Stack<BinaryTreeNode<T>>();
            stack.Push(tree);

            while (stack.Count > 0)
            {
                var node = stack.Pop();
                if (node == null)
                {
                    continue;
                }

                output.Push(node.Value);
                stack.Push(node.LeftChild);
                stack.Push(node.RightChild);
            }
        }

        public static void PreOrderRecursively<T>(BinaryTreeNode<T> tree, List<T> output) where T : IComparable<T>
        {
            if (tree == null)
            {
                return;
            }

            output.Add(tree.Value);
            PreOrderRecursively(tree.LeftChild, output);
            PreOrderRecursively(tree.RightChild, output);
        }

        public static void PostOrderRecursively<T>(BinaryTreeNode<T> tree, List<T> output) where T : IComparable<T>
        {
            if (tree == null)
            {
                return;
            }

            PostOrderRecursively(tree.LeftChild, output);
            PostOrderRecursively(tree.RightChild, output);
            output.Add(tree.Value);
        }

        public static void MidOrderRecursively<T>(BinaryTreeNode<T> tree, List<T> output) where T : IComparable<T>
        {
            if (tree == null)
            {
                return;
            }

            MidOrderRecursively(tree.LeftChild, output);
            output.Add(tree.Value);
            MidOrderRecursively(tree.RightChild, output);
        }
    }
}
