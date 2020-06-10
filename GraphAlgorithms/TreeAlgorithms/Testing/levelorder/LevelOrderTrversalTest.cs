using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeAlgorithms.BST;
using TreeAlgorithms.BST.insert;
using TreeAlgorithms.BST.levelorder;

namespace TreeAlgorithms.Testing.levelorder
{
    public class LevelOrderTrversalTest
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

            LevelOrderTrversal.LevelOrderTraversalTree(root);

            Console.ReadKey();
        }
    }
}
