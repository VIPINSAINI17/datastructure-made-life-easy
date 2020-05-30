using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlgorithms.adjacencylistrepresentation_directedgraph
{
    public class AdjenceyListDirectedGraph
    {
        static int N = 6;

        static LinkedList<int>[] adj = new LinkedList<int>[N];


        public static void GenerateAdjList()
        {
            for (int i = 0; i < N; i++)
                adj[i] = new LinkedList<int>();

            addEdge(adj, 5, 2);
            addEdge(adj, 5, 0);
            addEdge(adj, 4, 0);
            addEdge(adj, 4, 1);
            addEdge(adj, 2, 3);
            addEdge(adj, 3, 1);
            //Print
            printGraph(adj);

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

        public static void addEdge(LinkedList<int>[] adj, int u, int v)
        {
            Console.WriteLine("added {0}, {1}", u, v);
            adj[u].AddLast(v);


        }
    }
}
