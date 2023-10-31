// using System;
// using System.Collections.Generic;
// using System.Linq;

// class LeastConnectionsBalancer
// {
//     private Dictionary<string, int> resourceConnections;

//     public LeastConnectionsBalancer(List<string> availableResources)
//     {
//         resourceConnections = availableResources.ToDictionary(resource => resource, resource => 0);
//     }

//     public string AssignTask()
//     {
//         if (resourceConnections.Count == 0)
//             return null;

//         string selectedResource = resourceConnections.OrderBy(pair => pair.Value).First().Key;
//         resourceConnections[selectedResource]++; // Incrementa as conexões ativas
//         return selectedResource;
//     }

//     public void ReleaseTask(string resource)
//     {
//         if (resourceConnections.ContainsKey(resource) && resourceConnections[resource] > 0)
//             resourceConnections[resource]--; // Libera uma conexão
//     }
// }

// // Exemplo de uso
// class Program
// {
//     static void Main()
//     {
//         List<string> availableResources = new List<string> { "ResourceA", "ResourceB", "ResourceC" };
//         LeastConnectionsBalancer balancer = new LeastConnectionsBalancer(availableResources);

//         for (int i = 0; i < 10; i++)
//         {
//             string assignedResource = balancer.AssignTask();
//             Console.WriteLine($"Task {i + 1} assigned to {assignedResource}");
//         }

//         // Simulando a liberação de conexões após o término das tarefas
//         balancer.ReleaseTask("ResourceA");
//         balancer.ReleaseTask("ResourceC");
//     }
// }
