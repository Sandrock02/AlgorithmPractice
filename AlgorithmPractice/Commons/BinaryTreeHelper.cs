using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Commons
{
    public static class BinaryTreeHelper
    {
        public static BinaryTreeNode<T> BuildTree<T>(T[] treeNodes, IList<int> validIndices = null) 
            where T : IComparable<T>
        {
            if(treeNodes == null) throw new ArgumentNullException();
            if(treeNodes.Length == 0) return null;

            if(validIndices == null)
            {
                validIndices = treeNodes.GetAllValid();
            }

            var root = new BinaryTreeNode<T>(treeNodes[0]);
            BuildTreeChildren(root, treeNodes, validIndices, 0);
            return root;
        }

        private static void BuildTreeChildren<T>(BinaryTreeNode<T> node, T[] treeNodes, IList<int> validIndices, int i) 
            where T : IComparable<T>
        {
            int lc = i * 2 + 1;
            int rc = i * 2 + 2;
            if (lc < treeNodes.Length && validIndices.Contains(lc))
            {
                node.LeftChild = new BinaryTreeNode<T>(treeNodes[lc]);
                BuildTreeChildren(node.LeftChild, treeNodes, validIndices, lc);
            }

            if (rc < treeNodes.Length && validIndices.Contains(rc))
            {
                node.RightChild = new BinaryTreeNode<T>(treeNodes[rc]);
                BuildTreeChildren(node.RightChild, treeNodes, validIndices, rc);
            }
        }

        private static IList<int> GetAllValid<T>(this T[] valueArray)
            where T : IComparable<T>
        {
            var list = new List<int>();
            for (int i = 0; i < valueArray.Length; i++)
                list.Add(i);
            return list;
        }
    }
}
