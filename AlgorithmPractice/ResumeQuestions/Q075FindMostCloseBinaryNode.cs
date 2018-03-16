using AlgorithmPractice.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.ResumeQuestions
{
    public class Q075FindMostCloseBinaryNode
    {
        public static bool FindNode<T>(BinaryTreeNode<T> root, BinaryTreeNode<T> n1, BinaryTreeNode<T> n2, out BinaryTreeNode<T> foundNode)
            where T : IComparable<T>
        {
            foundNode = null;
            BinaryTreeNode<T> foundLeft = null;
            BinaryTreeNode<T> foundRight = null;

            bool result = false;
            if (n1 == null || n2 == null || n1 == n2 || root == null) return false;

            if (root == n1 || root == n2) result = true;

            var node1 = FindNode(root.LeftChild, n1, n2, out foundLeft);
            if (node1 && foundLeft != null)
            {
                foundNode = foundLeft;
                return true;
            }

            var node2 = FindNode(root.RightChild, n1, n2, out foundRight);
            if (node2 && foundRight != null)
            {
                foundNode = foundRight;
                return true;
            }

            if ((node1 && node2) || (result && (node1 || node2)))
            {
                foundNode = root;
                return true;
            }
            else if (node1 || node2)
            {
                return true;
            }

            return result;
        }

        public static BinaryTreeNode<T> FindNode<T>(BinaryTreeNode<T> root, BinaryTreeNode<T> n1, BinaryTreeNode<T> n2)
            where T : IComparable<T>
        {
            if (root == null || n1 == null || n2 == null || n1 == n2) return null;
            if (n1 == root || n2 == root) return root;

            var left = FindNode(root.LeftChild, n1, n2);
            var right = FindNode(root.RightChild, n1, n2);

            if (left == null) return right;
            else if (right == null) return left;
            else return root;
        }
    }
}
