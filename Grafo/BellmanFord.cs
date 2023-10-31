// using System;
// using System.Collections.Generic;

// class BellmanFord
// {
//     public static Dictionary<string, int> FindShortestPath(Dictionary<string, List<(string, int)>> graph, string startNode)
//     {
//         Dictionary<string, int> distances = new Dictionary<string, int>();
//         Dictionary<string, string> previousNodes = new Dictionary<string, string>();

//         foreach (string node in graph.Keys)
//         {
//             distances[node] = int.MaxValue;
//         }
//         distances[startNode] = 0;

//         for (int i = 0; i < graph.Count - 1; i++)
//         {
//             foreach (string node in graph.Keys)
//             {
//                 foreach ((string, int) edge in graph[node])
//                 {
//                     string neighbor = edge.Item1;
//                     int weight = edge.Item2;
//                     if (distances[node] != int.MaxValue && distances[node] + weight < distances[neighbor])
//                     {
//                         distances[neighbor] = distances[node] + weight;
//                         previousNodes[neighbor] = node;
//                     }
//                 }
//             }
//         }

//         return distances;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Dictionary<string, List<(string, int)>> graph = new Dictionary<string, List<(string, int)>>
//         {
//             { "A", new List<(string, int)> { ("B", 2), ("C", 4) } },
//             { "B", new List<(string, int)> { ("C", 1), ("D", 7) } },
//             { "C", new List<(string, int)> { ("D", 3) } },
//             { "D", new List<(string, int)>() }
//         };

//         Dictionary<string, int> shortestDistances = BellmanFord.FindShortestPath(graph, "A");

//         foreach (KeyValuePair<string, int> entry in shortestDistances)
//         {
//             Console.WriteLine($"Shortest distance from A to {entry.Key}: {entry.Value}");
//         }
//     }
// }
