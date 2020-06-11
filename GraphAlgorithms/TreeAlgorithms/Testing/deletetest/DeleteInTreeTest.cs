using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeAlgorithms.BST;
using TreeAlgorithms.BST.delete;
using TreeAlgorithms.BST.insert;

namespace TreeAlgorithms.Testing.deletetest
{
    public class DeleteInTreeTest
    {
        static TreeNode root = null;
        public static void InsertNodeToTreeRoot()
        {
            root = InsertInTree.InsertIntoTree(null, 50);
            InsertNodeToTreeNonRoot();
        }

        public static void InsertNodeToTreeNonRoot()
        {

            root = InsertInTree.InsertIntoTree(root, 30);
            root = InsertInTree.InsertIntoTree(root, 20);
            root = InsertInTree.InsertIntoTree(root, 40);
            root = InsertInTree.InsertIntoTree(root, 70);
            root = InsertInTree.InsertIntoTree(root, 60);
            root = InsertInTree.InsertIntoTree(root, 80);

            //DeleteInTree.DeleteNodeOfBST(root,20);

            DeleteInTree.DeleteNodeOfBST(root, 30);

            Console.ReadKey();
        }
    }
}
