using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeAlgorithms.BST.delete
{
    //    Binary Search Tree Delete
    // When we delete a node, three possibilities arise.
    //1) Node to be deleted is leaf: Simply remove from the tree.

    //              50                            50
    //           /     \         delete(20)      /   \
    //          30      70       --------->    30     70 
    //         /  \    /  \                     \    /  \ 
    //       20   40  60   80                   40  60   80
    //2) Node to be deleted has only one child: Copy the child to the node and delete the child

    //              50                            50    
    //           /     \         delete(30)      /   \
    //          30      70       --------->    40     70 
    //            \    /  \                          /  \ 
    //            40  60   80                       60   80
    //3) Node to be deleted has two children: Find inorder successor of the node. 
    // Copy contents of the inorder successor to the node and delete the inorder successor. Note that inorder predecessor can also be used.
    
    public class DeleteInTree
    {
        // Helper Method for delete
        public static TreeNode DeleteNodeOfBST(TreeNode root, int value)
        {
            if (root == null)
            {
                Console.WriteLine("Value not found in BST");
                return null;
            }
            if (value < root.Data)
            {
                root.Left = DeleteNodeOfBST(root.Left, value);
            }
            else if (value > root.Data)
            {
                root.Right = DeleteNodeOfBST(root.Right, value);
            }
            else
            { // If currentNode is the node to be deleted

                if (root.Left != null && root.Right != null)  // if nodeToBeDeleted have both children
                {
                    TreeNode temp = root;
                    TreeNode minNodeForRight = minimumElement(temp.Right);// Finding minimum element from right subtree
                    root.Data = minNodeForRight.Data; // Replacing current node with minimum node from right subtree
                    root.Right = DeleteNodeOfBST(root.Right, minNodeForRight.Data);  // Deleting minimum node from right now
                }
                else if (root.Left != null) // if nodeToBeDeleted has only left child
                {
                    root = root.Left;
                }
                else if (root.Right != null) // if nodeToBeDeleted has only right child
                {
                    root = root.Right;
                }
                else // if nodeToBeDeleted do not have child (Leaf node)
                    root = null;
            }
            return root;
        }// end of method


        // Get minimum element in binary search tree
        public static TreeNode minimumElement(TreeNode root)
        {
            if (root.Left == null)
                return root;
            else
            {
                return minimumElement(root.Left);
            }
        }// end of method
    }
}
