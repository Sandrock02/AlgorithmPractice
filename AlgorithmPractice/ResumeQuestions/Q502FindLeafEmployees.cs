using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.ResumeQuestions
{
    using AlgorithmPractice.OtherStructures;

    public class Q502FindLeafEmployees
    {
        public static SelfRefObject<string>[] GetLeafNodes(SelfRefObject<string>[] nodes)
        {
            var leaf = new HashSet<SelfRefObject<string>>();
            var parent = new HashSet<SelfRefObject<string>>();

            foreach (var node in nodes)
            {
                if (parent.Contains(node))
                {
                    continue;
                }

                // Add if not exist
                if (!leaf.Contains(node))
                {
                    leaf.Add(node);
                }

                // Check parent
                CheckParent(node, leaf, parent);
            }

            return leaf.ToArray();
        }

        private static void CheckParent(SelfRefObject<string> node, HashSet<SelfRefObject<string>> leaf,
            HashSet<SelfRefObject<string>> parent)
        {
            while (node.Parent != null && !parent.Contains(node.Parent))
            {
                if (leaf.Contains(node.Parent))
                {
                    leaf.Remove(node.Parent);
                }

                parent.Add(node.Parent);
            }
        }
    }
}
