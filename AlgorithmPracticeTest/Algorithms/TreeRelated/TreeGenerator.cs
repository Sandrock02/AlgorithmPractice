namespace AlgorithmPracticeTest.Algorithms.TreeRelated
{
    using AlgorithmPractice.Commons;

    internal static class TreeGenerator
    {
        /// <summary>
        /// Get simple normal tree
        /// </summary>
        /// <returns>The tree root</returns>
        /// <remarks>
        /// The tree is like below:
        ///    A
        ///   / \
        ///  B   C
        /// / \ / \
        /// D E F G
        /// </remarks>
        public static BinaryTreeNode<string> GetSimpleNormalTree()
        {
            var root = new BinaryTreeNode<string>(
                "A",
                new BinaryTreeNode<string>("B", new BinaryTreeNode<string>("D"), new BinaryTreeNode<string>("E")),
                new BinaryTreeNode<string>("C", new BinaryTreeNode<string>("F"), new BinaryTreeNode<string>("G")));

            return root;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        ///          A
        ///         / \
        ///        B   C
        ///       /   / \
        ///       D   E F
        ///          /
        ///         G
        /// </remarks>
        /// <returns></returns>
        public static BinaryTreeNode<string> GetSimpleTree()
        {
            var root = new BinaryTreeNode<string>(
                "A",
                new BinaryTreeNode<string>("B", new BinaryTreeNode<string>("D")),
                new BinaryTreeNode<string>("C", 
                    new BinaryTreeNode<string>("E",
                        new BinaryTreeNode<string>("G")), 
                    new BinaryTreeNode<string>("F")));

            return root;
        }
    }
}
