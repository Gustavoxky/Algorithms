// using System;
// using System.Collections.Generic;

// class RoundRobinBalancer
// {
//     private List<string> resources;
//     private int currentIndex;

//     public RoundRobinBalancer(List<string> availableResources)
//     {
//         resources = availableResources;
//         currentIndex = 0;
//     }

//     public string AssignTask()
//     {
//         if (resources.Count == 0)
//             return null;

//         string selectedResource = resources[currentIndex];
//         currentIndex = (currentIndex + 1) % resources.Count; // Avança para o próximo recurso
//         return selectedResource;
//     }
// }

// // Exemplo de uso
// class Program
// {
//     static void Main()
//     {
//         List<string> availableResources = new List<string> { "ResourceA", "ResourceB", "ResourceC" };
//         RoundRobinBalancer balancer = new RoundRobinBalancer(availableResources);

//         for (int i = 0; i < 10; i++)
//         {
//             string assignedResource = balancer.AssignTask();
//             Console.WriteLine($"Task {i + 1} assigned to {assignedResource}");
//         }
//     }
// }
