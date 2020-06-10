using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeAlgorithms.BST.levelorder
{
    public class LevelOrderTrversal
    {
        public static void LevelOrderTraversalTree(TreeNode root)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            Console.WriteLine("Printing Level order traversal of Tree...");
            if (root == null)
            {
                Console.WriteLine("Tree does not exists !");
                return;
            }
            while (queue.Count != 0)
            {
                TreeNode presentNode = queue.Dequeue();
                Console.WriteLine(presentNode.Data + " ");
                if (presentNode.Left != null)
                    queue.Enqueue(presentNode.Left);
                if (presentNode.Right != null)
                    queue.Enqueue(presentNode.Right);
            }
        }// end of method
    }
}
