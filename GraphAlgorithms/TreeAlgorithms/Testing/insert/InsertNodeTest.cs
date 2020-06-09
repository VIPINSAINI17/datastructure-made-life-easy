using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeAlgorithms.BST;
using TreeAlgorithms.BST.insert;

namespace TreeAlgorithms.Testing.insert
{
    public class InsertNodeTest
    {
        TreeNode root = null;
        public void InsertNodeToTreeRoot()
        {
             root = InsertInTree.InsertIntoTree(null, 10);
            InsertNodeToTreeNonRoot();
        }

        public void InsertNodeToTreeNonRoot()
        {
             root = InsertInTree.InsertIntoTree(root, 4);
             root = InsertInTree.InsertIntoTree(root, 30);
             root = InsertInTree.InsertIntoTree(root, 40);
             root = InsertInTree.InsertIntoTree(root, 7);
        }
    }
}
