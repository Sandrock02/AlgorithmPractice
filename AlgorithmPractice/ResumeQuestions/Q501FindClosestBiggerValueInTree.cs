namespace AlgorithmPractice.ResumeQuestions
{
    using AlgorithmPractice.Commons;

    public class Q501FindClosestBiggerValueInTree
    {
        public static BinaryTreeNode<int> FindClosestBiggerValueEx(BinaryTreeNode<int> root, int value)
        {
            BinaryTreeNode<int> node = root;
            BinaryTreeNode<int> closeNode = null;

            while (node != null)
            {
                if (node.Value > value)
                {
                    if (closeNode == null || node.Value < closeNode.Value)
                    {
                        closeNode = node;
                    }

                    node = node.LeftChild;
                }
                else
                {
                    node = node.RightChild;
                }
            }

            return closeNode;
        }

        public static BinaryTreeNode<int> FindClosestBiggerValue(BinaryTreeNode<int> root, int value)
        {
            if (root == null) return null;

            var rootDiff = root.Value - value;
            BinaryTreeNode<int> node;
            if (rootDiff > 0)
            {
                // Find in left tree
                if (root.LeftChild == null) return root;
                node = FindClosestBiggerValue(root.LeftChild, value);
            }
            else
            {
                // Find in right tree
                if (root.RightChild == null) return root;
                node = FindClosestBiggerValue(root.RightChild, value);
            }

            var nodeDiff = node.Value - value;

            if (nodeDiff > 0 && rootDiff > 0 && nodeDiff < rootDiff)
                return node;
            if (nodeDiff > 0 && rootDiff <= 0)
                return node;
            return root;
        }
    }
}
