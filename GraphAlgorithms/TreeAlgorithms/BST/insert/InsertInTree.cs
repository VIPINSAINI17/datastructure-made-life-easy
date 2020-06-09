using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeAlgorithms.BST;

namespace TreeAlgorithms.BST.insert
{
    public class InsertInTree
    {
        /// <summary>
        /// This will insert a new node for a tree in recursive way.
        /// TODO - Time Complexity
        /// TODO - Space Complexity 
        /// </summary>
        /// <param name="root"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static TreeNode InsertIntoTree(TreeNode root, int data) {

            //TODO - Check first if this is the first node to insert which will be the root
            if (root == null)
            {
                TreeNode rootNode = new TreeNode(data);
                return rootNode;
            }

            // TODO -if root node is already setup means either this insertion will be on left or right
            // TODO insert on left if value is less than root node
            // TODO insert on right if value is greater than root node 

            if (root.Data < data) // Right
                InsertIntoTree(root.Right, data);
            if(root.Data > data) // Left
                InsertIntoTree(root.Left, data);

            /* return the (unchanged) node pointer */
            return root;
        }
    }
}
