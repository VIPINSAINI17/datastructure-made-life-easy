using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeAlgorithms.BST.search
{
    //    Binary Search Tree Delete
    // When we delete a node, three possibilities arise.
    //1) Find a value in the below given tree

    //              50                           
    //           /     \         
    //          30      70      
    //         /  \    /  \        
    //       20   40  60   80            

    public class SearchInTree
    {
        public static TreeNode SearchForValue(TreeNode node, int value)
        {
            if (node == null) // BASECASE-1 : Check for the incoming node is null
            {
                Console.WriteLine("Value: " + value + " not found in BST.");
                return null;
            }
            else if (node.Data == value) // BASECASE-2 - Check if incoming  
            {
                Console.WriteLine("Value: " + value + " found in BST.");
                return node;
            }
            else if (value < node.Data)  // If find value is less than current value, can be find in left recusively 
            {
                return SearchForValue(node.Left, value);
            }
            else // If find value is greater than current value, can be find in left recusively 
            {
                return SearchForValue(node.Right, value);
            }
        }// end of method
    }
}
