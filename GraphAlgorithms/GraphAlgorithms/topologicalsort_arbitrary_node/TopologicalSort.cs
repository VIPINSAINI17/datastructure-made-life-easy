﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlgorithms.topologicalsort_arbitrary_node
{

    // TODO - Add more comments for code readability 

    public class TopologicalSorting
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


            bool[] visited = new bool[N];

            // Used an arbitratry node to process topological sort
            // 0,1,2,3,4,5,
            Topological(3, visited);

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


        public static void TopologicalSort(int enrtyVertex, bool[] visited, Stack<int> stack)
        {
            LinkedList<int> adjList = adj[enrtyVertex];

            visited[enrtyVertex] = true;

            foreach (int item in adjList)
            {
                if (!visited[item])
                    TopologicalSort(item, visited, stack);
            }

            stack.Push(enrtyVertex);

        }

        public static void Topological(int enrtyVertex, bool[] visited)
        {
            visited[enrtyVertex] = true;
            Stack<int> stack = new Stack<int>();
            TopologicalSort(enrtyVertex, visited, stack);
            for (int i = 0; i < N; i++)
            {

                if (enrtyVertex != i && !visited[i])
                    TopologicalSort(i, visited, stack);
            }

            // Print contents of stack  
            while (stack.Count != 0)
                Console.Write(stack.Pop() + " ");
        }
    }
}
