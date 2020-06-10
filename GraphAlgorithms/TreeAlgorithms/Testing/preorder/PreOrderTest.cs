using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeAlgorithms.BST;
using TreeAlgorithms.BST.insert;
using TreeAlgorithms.BST.preorder;

namespace TreeAlgorithms.Testing.preorder
{
    public class PreOrderTest
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

            PreOrderTrversal.PreOrder(root);

            Console.ReadKey();
        }
    }
}
