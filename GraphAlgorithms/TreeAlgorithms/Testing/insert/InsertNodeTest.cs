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
             root = InsertInTree.InsertIntoTree(null, 50);
            InsertNodeToTreeNonRoot();
        }

        public void InsertNodeToTreeNonRoot()
        {
            //tree.insert(50);
            //tree.insert(30);
            //tree.insert(20);
            //tree.insert(40);
            //tree.insert(70);
            //tree.insert(60);
            //tree.insert(80); 
             root = InsertInTree.InsertIntoTree(root, 30);
             root = InsertInTree.InsertIntoTree(root, 20);
             root = InsertInTree.InsertIntoTree(root, 40);
             root = InsertInTree.InsertIntoTree(root, 70);
             root = InsertInTree.InsertIntoTree(root, 60);
             root = InsertInTree.InsertIntoTree(root, 80);
        }
    }
}
