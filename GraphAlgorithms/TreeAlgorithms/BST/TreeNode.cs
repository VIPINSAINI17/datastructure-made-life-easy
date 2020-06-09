using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeAlgorithms.BST
{
    public class TreeNode
    {
        public int Data { get; set; }
        public TreeNode Right { get; set; }
        public TreeNode Left { get; set; }

        public TreeNode(int data)
        {
            this.Data = data;
        }
    }
}
