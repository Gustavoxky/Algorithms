// using System;
// using System.Collections.Generic;

// class Dijkstra
// {
//     public static Dictionary<string, int> FindShortestPath(Dictionary<string, Dictionary<string, int>> graph, string startNode)
//     {
//         Dictionary<string, int> distances = new Dictionary<string, int>();
//         Dictionary<string, string> previousNodes = new Dictionary<string, string>();
//         List<string> unvisitedNodes = new List<string>(graph.Keys);

//         foreach (string node in unvisitedNodes)
//         {
//             distances[node] = int.MaxValue;
//         }
//         distances[startNode] = 0;

//         while (unvisitedNodes.Count > 0)
//         {
//             string currentNode = FindSmallestDistanceNode(distances, unvisitedNodes);
//             unvisitedNodes.Remove(currentNode);

//             foreach (KeyValuePair<string, int> neighbor in graph[currentNode])
//             {
//                 int distance = distances[currentNode] + neighbor.Value;
//                 if (distance < distances[neighbor.Key])
//                 {
//                     distances[neighbor.Key] = distance;
//                     previousNodes[neighbor.Key] = currentNode;
//                 }
//             }
//         }

//         return distances;
//     }

//     private static string FindSmallestDistanceNode(Dictionary<string, int> distances, List<string> unvisitedNodes)
//     {
//         int smallestDistance = int.MaxValue;
//         string smallestDistanceNode = null;
//         foreach (string node in unvisitedNodes)
//         {
//             if (distances[node] < smallestDistance)
//             {
//                 smallestDistance = distances[node];
//                 smallestDistanceNode = node;
//             }
//         }
//         return smallestDistanceNode;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Dictionary<string, Dictionary<string, int>> graph = new Dictionary<string, Dictionary<string, int>>
//         {
//             { "A", new Dictionary<string, int> { { "B", 2 }, { "C", 4 } } },
//             { "B", new Dictionary<string, int> { { "C", 1 }, { "D", 7 } } },
//             { "C", new Dictionary<string, int> { { "D", 3 } } },
//             { "D", new Dictionary<string, int>() }
//         };

//         Dictionary<string, int> shortestDistances = Dijkstra.FindShortestPath(graph, "A");

//         foreach (KeyValuePair<string, int> entry in shortestDistances)
//         {
//             Console.WriteLine($"Shortest distance from A to {entry.Key}: {entry.Value}");
//         }
//     }
// }
