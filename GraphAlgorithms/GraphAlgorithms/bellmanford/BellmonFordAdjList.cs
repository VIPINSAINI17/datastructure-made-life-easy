using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlgorithms.bellmanford
{
    public class BellmonFordAdjList
    {
         static int N = 5;

         static LinkedList<WeightedNode>[] adj = new LinkedList<WeightedNode>[N];
        public static void GenerateAdjList()
        {
            for (int i = 0; i < N; i++)
                adj[i] = new LinkedList<WeightedNode>();

            addWeightedEdge(adj,1, 3, 6); //Add A-> C , weight 6
            addWeightedEdge(adj, 2, 1, 3); //Add B-> A , weight 3
            addWeightedEdge(adj,1, 4, 6); //Add A-> D , weight 6
            //graph.addWeightedEdge(1,4,-6); //Add A-> D , weight -6 TEST NEGATIVE WEIGHT HERE
            addWeightedEdge(adj, 4, 3, 1); //Add D-> C , weight 1
            addWeightedEdge(adj, 3, 4, 2); //Add C-> D , weight 2
            addWeightedEdge(adj, 4, 2, 1); //Add D-> B , weight 1
            addWeightedEdge(adj, 5, 4, 2); //Add E-> D , weight 2
            addWeightedEdge(adj, 5, 2, 4); //Add E-> B , weight 4


            bool[] visited = new bool[N];

        }

        public static void printGraph(LinkedList<int>[] adj)
        {
            for (int i = 0; i < adj.Length; i++)
            {
                Console.WriteLine("\nAdjacency list of vertex " + i);
                Console.Write("head");

                foreach (var item in adj[i])
                {
                    Console.Write(" -> " + item);
                }
                Console.WriteLine();
            }
        }

        public static void addWeightedEdge(LinkedList<WeightedNode>[] adjList, int u, int v, int weight)
        {
            LinkedList<WeightedNode> nextNode = new LinkedList<WeightedNode>(adjList[v - 1]);

            LinkedListNode<String> lln = new LinkedListNode<String>("orange");

            //adjList[u - 1].AddLast(nextNode);

        }
    }
}
