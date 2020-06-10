using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeAlgorithms.BST.preorder
{
    public class PreOrderTrversal
    {
        public static void PreOrder(TreeNode root)
        {
            if (root != null)
            {
                Console.WriteLine(root.Data);
                PreOrder(root.Left);
                PreOrder(root.Right);

            }

        }
    }
}
