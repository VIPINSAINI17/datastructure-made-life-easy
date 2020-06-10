using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeAlgorithms.BST;
using TreeAlgorithms.BST.inorder;
using TreeAlgorithms.BST.insert;

namespace TreeAlgorithms.Testing.inorder
{
    public class InOrderTest
    {
        TreeNode root = null;
        public void InsertNodeToTreeRoot()
        {
            root = InsertInTree.InsertIntoTree(null, 50);
            InsertNodeToTreeNonRoot();
        }

        public void InsertNodeToTreeNonRoot()
        {
 
            root = InsertInTree.InsertIntoTree(root, 30);
            root = InsertInTree.InsertIntoTree(root, 20);
            root = InsertInTree.InsertIntoTree(root, 40);
            root = InsertInTree.InsertIntoTree(root, 70);
            root = InsertInTree.InsertIntoTree(root, 60);
            root = InsertInTree.InsertIntoTree(root, 80);

            InOrderTrversal.InorderRec(root);

            Console.ReadKey();
        }
    }
}
