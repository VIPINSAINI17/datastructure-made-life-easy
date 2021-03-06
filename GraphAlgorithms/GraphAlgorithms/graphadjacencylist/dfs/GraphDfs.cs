﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlgorithms.graphadjacencylist.dfs
{
    public static class GraphDfs
    {
        public static void GenerateAdjList()
        {
            for (int i = 0; i < N; i++)
                adj[i] = new LinkedList<int>();

            addEdge(adj, 0, 1);
            addEdge(adj, 0, 4);
            addEdge(adj, 1, 2);
            addEdge(adj, 1, 3);
            addEdge(adj, 1, 4);
            addEdge(adj, 2, 3);
            addEdge(adj, 3, 4);
            printGraph(adj);


            bool[] visited = new bool[N];
            DFS(1, visited);

        }


        static int N = 5;

        static LinkedList<int>[] adj = new LinkedList<int>[N];

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
            adj[v].AddLast(u);
        }

        public static void DFS(int a, bool[] visited)
        {
            Console.WriteLine(a);

            LinkedList<int> adjList = adj[a];

            visited[a] = true;


            foreach (int item in adjList)
            {
                if (!visited[item])
                {
                    DFS(item, visited);
                }
            }
        }
    }
}
