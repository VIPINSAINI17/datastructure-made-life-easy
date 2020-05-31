# datastructure-made-life-easy
Most simple way to explain every single data structure 


Graph Data Structure :

Representations
1. Adjacency list
2. Adjacency matrix

Graph Applications

Algorithms that use depth-first search as a building block include:
                            OR
                    In Order Traversal

    1. Finding connected components.
    2. Topological sorting.
    3. Finding the bridges of a graph.
    4. Generating words in order to plot the limit set of a group.
    5. Finding strongly connected components.
    6. Planarity testing
    7. Solving puzzles with only one solution, such as mazes. (DFS can be adapted to find all solutions to a maze by only including nodes on the current path in the visited set.)
    8. Maze generation may use a randomized depth-first search.
    9. Finding biconnectivity in graphs.
    
 Breadth-first search can be used to solve many problems in graph theory, for example:
                               OR
                       Level Order Traversal 
                       
    It's uses Queue data structure to implement BFS

    1. Copying garbage collection, Cheney's algorithm
    2. Finding the shortest path between two nodes u and v, with path length measured by number of edges (an advantage over depth-first search)[10]
    (Reverse) Cuthill–McKee mesh numbering
    3. Ford–Fulkerson method for computing the maximum flow in a flow network
    4. Serialization/Deserialization of a binary tree vs serialization in sorted order, allows the tree to be re-constructed in an efficient manner.
    5. Construction of the failure function of the Aho-Corasick pattern matcher.
    6. Testing bipartiteness of a graph.
    
  Other Applications 
   1. To find a shortest path between source and destinations 
   2. Minimum spanning tree
   3. To solve salesman problem
   4. Topological sorting 
  
Topological sorting 

    1. Graph must be directed 
    2. No Cycle 
    3. DAG(Directed Acyclic Graph) has at least one topological sorting order 
    4. DFS -Depth first search can be used to implement Topological sorting 
    
Single Source Shortest Path Algorithm

    1. Using BFS
    2. Using DFS
    3. Using Dijkastra 
    4. Using Bellman ford
