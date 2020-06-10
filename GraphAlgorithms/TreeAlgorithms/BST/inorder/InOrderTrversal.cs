using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeAlgorithms.BST.inorder
{
    public class InOrderTrversal
    {
        // A utility function to do inorder traversal of BST 
        public static void InorderRec(TreeNode root)
        {
            if (root != null)
            {
                InorderRec(root.Left);
                Console.WriteLine(root.Data);
                InorderRec(root.Right);
            }
        }
    }
}
