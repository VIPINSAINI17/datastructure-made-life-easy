
Very good links
https://duncan-mcardle.medium.com/leetcode-problem-2-longest-substring-without-repeating-characters-javascript-993890bf8eac

https://www.interviewbit.com/blog/longest-substring-without-repeating-characters/


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

    1. Using BFS - Will not work for the weighted directed/undirected graph to find the shortest path.
    2. Using DFS
    3. Using Dijkastra 
    4. Using Bellman ford
    5. Graph will be alwsys connected, no isolated nodes 


Tree Data Structure 

     1. Tree Traversal Pre Order, Post Order and In Order   -----------Uses Stack.
     2. Level Order Traversal -----------Uses Queue

Tree Breadth-first search / level order

Main article: Breadth-first search
Trees can also be traversed in level-order, where we visit every node on a level before going to a lower level. This search is referred to as breadth-first search (BFS), as the search tree is broadened as much as possible on each depth before going to the next depth.



// Factorial

function factorial(x){
    
    if(x < 0){
        console.log('number is not valid');
    }
    else if( x == 0){
        return 1;
    }
    else{
        return x*factorial(x-1)
    }
}

const result = factorial(5);
console.log(result);

// fib

function fib(x)
{
 if(x==0) return 0;
 else if(x== 1) return 1;

 return fib(x-1) + fib(x-2);
}

for(i=0;i< 5; i++){
    console.log(fib(i));
}


======================================Length of longest string with javascript====================
var lengthOfLongestSubstring = function (s) {
    // Store counters for the the start of the window and the longest string's length
    var startOfWindow = 0,
        longestStringLength = 0;

    // Initialise a Map to store the characters of the current string
    var characterMap = new Map();

    // Loop through the provided string
    for (let i = 0; i < s.length; i++) {
        // Store the current character, and its position in the Map (saves repeatedly looking it up)
        let currentCharacter = s[i];
        let currentCharacterPositionInMap = characterMap.get(currentCharacter);
        //console.log(currentCharacterPositionInMap);
        // Check if current character exists in the Map, and was found within the current window
        if (currentCharacterPositionInMap >= startOfWindow) {
            // Move the current window to start after the first instance of the current character
            startOfWindow = currentCharacterPositionInMap + 1;
        }

        // Add the current character to the Map with its position in the string
        characterMap.set(currentCharacter, i);


        // Store the current string length if bigger than the existing record
        longestStringLength = Math.max(
            longestStringLength,
            i - startOfWindow + 1
        );
    }
    console.log(characterMap);

    return longestStringLength;
};

console.log(lengthOfLongestSubstring("abaaaa"));


// check for anagram
// check for anagram

function checkForAnagram(s1,s2){

    let strLen1 = s1.length;
    let strLen2 = s2.length;

    if(strLen1 != strLen2) return false;

    // sort both strings
    s1.sort();
    s2.sort();

    // compare both the strings
    for(let i = 0; i< s1.length; i++){
        if(s1[i] != s2[i]) return false;
    }

    return true;
}


     
// Driver Code
let str1=['t', 'e', 's', 't'];
let str2=['t', 'e', 's', 't'];
console.log(checkForAnagram(str1,str2))


// find anagrams

var findAnagrams = function(s, p) {
    let hashMap = new Map()
    for(let i = 0; i < p.length; i++) {
        if(hashMap.has(p[i])) {
            hashMap.set(p[i], hashMap.get(p[i]) + 1)
        } else {
            hashMap.set(p[i], 1)
        }
    }

    //console.log(hashMap);

    let res = new Array()
    let start = 0, end = 0
    while(end < s.length) {
        if(hashMap.get(s[end]) > 0) 
        {
            //console.log(hashMap.get(s[end]));
            hashMap.set(s[end], hashMap.get(s[end]) - 1)

            console.log(hashMap);
            end++ // 2
            if(end - start == p.length) {
                res.push(start)
            }
        } else if(start == end) {
            console.log('start== end');
            start++
            end++
        } else {
            console.log('else');
            hashMap.set(s[start], hashMap.get(s[start]) + 1) //a->1, b->1
            console.log(hashMap);
            start++ // 1,2
        }
    }
    return res
};


console.log(findAnagrams("axy", "ab"));
