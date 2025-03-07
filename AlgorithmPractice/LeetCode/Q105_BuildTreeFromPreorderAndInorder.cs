using AlgorithmPractice.Commons;
using System;

namespace AlgorithmPractice.LeetCode
{
    // ReSharper disable once InconsistentNaming
    public class Q105_BuildTreeFromPreorderAndInorder
    {

        public static BinaryTreeNode<int> BuildTree(int[] preorder, int[] inorder)
        {
            if (preorder.Length == 0) return null;

            return BuildTreeInternal(preorder.AsSpan(), inorder.AsSpan());

        }

        private static BinaryTreeNode<int> BuildTreeInternal(ReadOnlySpan<int> preorder, ReadOnlySpan<int> inorder)
        {
            if (preorder.Length == 0) return null;

            // The first node is the root.
            var root = preorder[0];

            // It's not possible to get -1.
            var rootNode = new BinaryTreeNode<int>(root);

            if (preorder.Length == 1) return rootNode;

            // Search the root in the inorder list, 
            var index = inorder.IndexOf(root);

            var preorderLeft = preorder.Slice(1, index);
            var preorderRight = preorder.Slice(index + 1);
            var inorderLeft = inorder.Slice(0, index);
            var inorderRight = inorder.Slice(index + 1);

            rootNode.LeftChild = BuildTreeInternal(preorderLeft, inorderLeft);
            rootNode.RightChild = BuildTreeInternal(preorderRight, inorderRight);

            return rootNode;
        }
    }
}
