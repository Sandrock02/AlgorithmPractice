using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.LeetCode
{
    public class Q120_TriangleMinPathSum
    {
        public static int MinimumTotal(IList<IList<int>> triangle)
        {
            int n = triangle.Count;
            if (n == 1) return triangle[0][0];

            // 使用一维数组来存储 DP 值
            int[] dp = new int[n];

            // 初始化 dp 数组为最后一行的值
            for (int i = 0; i < n; i++)
            {
                dp[i] = triangle[n - 1][i];
            }

            // 从倒数第二行开始向上计算
            for (int i = n - 2; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    dp[j] = Math.Min(dp[j], dp[j + 1]) + triangle[i][j];
                }
            }

            return dp[0];
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
                     }
        }

        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            if (preorder.Length == 0) return null;

            return BuildTreeInternal(preorder.AsSpan(), inorder.AsSpan());

        }

        public TreeNode BuildTreeInternal(ReadOnlySpan<int> preorder, ReadOnlySpan<int> inorder)
        {
            // The first node is the root.
            var root = preorder[0];

            // It's not possible to get -1.
            var rootNode = new TreeNode(root);

            if (preorder.Length == 0) return rootNode;

            // Search the root in the inorder list, 
            var index = inorder.IndexOf(root);

            var preorderLeft = preorder.Slice(1, index);
            var preorderRight = preorder.Slice(index + 1);
            var inorderLeft = inorder.Slice(0, index);
            var inorderRight = inorder.Slice(index + 1);

            rootNode.left = BuildTreeInternal(preorderLeft, inorderLeft);
            rootNode.right = BuildTreeInternal(preorderRight, inorderRight);

            return rootNode;
        }
    }
}
