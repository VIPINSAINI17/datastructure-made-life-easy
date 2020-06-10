using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeAlgorithms.BST.postorder
{
    public class PostOrderTrversal
    {

        public static void PostOrder(TreeNode root)
        {
            if (root != null)
            {
                PostOrder(root.Left);
                PostOrder(root.Right);
                Console.WriteLine(root.Data);         
            }

        }
    }
}
