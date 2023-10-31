// using System;
// using System.Collections.Generic;

// namespace Star

// class AStar
// {
//     public static List<string> FindShortestPath(Dictionary<string, Dictionary<string, int>> graph, string startNode, string endNode)
//     {
//         Dictionary<string, int> gScore = new Dictionary<string, int>();
//         Dictionary<string, int> fScore = new Dictionary<string, int>();
//         Dictionary<string, string> cameFrom = new Dictionary<string, string>();

//         List<string> openSet = new List<string> { startNode };

//         gScore[startNode] = 0;
//         fScore[startNode] = HeuristicCostEstimate(startNode, endNode);

//         while (openSet.Count > 0)
//         {
//             string currentNode = FindLowestFScoreNode(openSet, fScore);

//             if (currentNode == endNode)
//                 return ReconstructPath(cameFrom, currentNode);

//             openSet.Remove(currentNode);

//             foreach (KeyValuePair<string, int> neighbor in graph[currentNode])
//             {
//                 int tentativeGScore = gScore[currentNode] + neighbor.Value;

//                 if (!gScore.ContainsKey(neighbor.Key) || tentativeGScore < gScore[neighbor.Key])
//                 {
//                     cameFrom[neighbor.Key] = currentNode;
//                     gScore[neighbor.Key] = tentativeGScore;
//                     fScore[neighbor.Key] = gScore[neighbor.Key] + HeuristicCostEstimate(neighbor.Key, endNode);

//                     if (!openSet.Contains(neighbor.Key))
//                         openSet.Add(neighbor.Key);
//                 }
//             }
//         }

//         return new List<string>(); // No path found
//     }

//     private static int HeuristicCostEstimate(string currentNode, string endNode)
//     {
//         // Replace with a suitable heuristic for your problem.
//         return 0;
//     }

//     private static string FindLowestFScoreNode(List<string> openSet, Dictionary<string, int> fScore)
//     {
//         int lowestFScore = int.MaxValue;
//         string lowestFScoreNode = null;

//         foreach (string node in openSet)
//         {
//             if (fScore.ContainsKey(node) && fScore[node] < lowestFScore)
//             {
//                 lowestFScore = fScore[node];
//                 lowestFScoreNode = node;
//             }
//         }

//         return lowestFScoreNode;
//     }

//     private static List<string> ReconstructPath(Dictionary<string, string> cameFrom, string currentNode)
//     {
//         List<string> path = new List<string> { currentNode };

//         while (cameFrom.ContainsKey(currentNode))
//         {
//             currentNode = cameFrom[currentNode];
//             path.Insert(0, currentNode);
//         }

//         return path;
//     }
// }

// // class Program
// // {
// //     static void Main()
// //     {
// //         Dictionary<string, Dictionary<string, int>> graph = new Dictionary<string, Dictionary<string, int>>
// //         {
// //             { "A", new Dictionary<string, int> { { "B", 2 }, { "C", 4 } } },
// //             { "B", new Dictionary<string, int> { { "C", 1 }, { "D", 7 } } },
// //             { "C", new Dictionary<string, int> { { "D", 3 } } },
// //             { "D", new Dictionary<string, int>() }
// //         };

// //         List<string> shortestPath = AStar.FindShortestPath(graph, "A", "D");

// //         Console.WriteLine("Shortest path from A to D: " + string.Join(" -> ", shortestPath));
// //     }
// // }
