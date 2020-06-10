using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeAlgorithms.Testing.inorder;
using TreeAlgorithms.Testing.insert;
using TreeAlgorithms.Testing.postorder;
using TreeAlgorithms.Testing.preorder;

namespace TreeAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //InsertNodeTest insertNodeTest = new InsertNodeTest();
            //insertNodeTest.InsertNodeToTreeRoot();

            //InOrderTest inOrderTest = new InOrderTest();
            //inOrderTest.InsertNodeToTreeRoot();

            //PostOrderTest postOrderTest = new PostOrderTest();
            //postOrderTest.InsertNodeToTreeRoot();

            PreOrderTest preOrderTest = new PreOrderTest();
            preOrderTest.InsertNodeToTreeRoot();
        }
    }
}
