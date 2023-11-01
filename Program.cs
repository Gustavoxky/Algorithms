using System;
using Huff;
using LZW;
using Encrypt; 
using RSAEncrypt; 
using System.Security.Cryptography;
using SHAHash;
using Star;
using Bell;
using Dij;
using Least;
using Round;
using Generic;
using Tree;

class Program
{
    static void Main()
    {
        int[] arrHeapsort = { 12, 11, 13, 5, 6, 7 }; // Create an integer array to sort with Heapsort
        int[] arrMergesort = { 12, 11, 13, 5, 6, 7 }; // Create an integer array to sort with Mergesort
        int[] arrQuicksort = { 12, 11, 13, 5, 6, 7 }; // Create an integer array to sort with Quicksort

        Console.WriteLine("Array not sorted (Heapsort):");
        PrintArray(arrHeapsort);

        SortA.Heapsort.Sort(arrHeapsort); // Call the Sort method from the Heapsort class to sort the array

        Console.WriteLine("Array sorted (Heapsort):");
        PrintArray(arrHeapsort);

        Console.WriteLine();

        Console.WriteLine("Array not sorted (Mergesort):");
        PrintArray(arrMergesort);

        SortB.Mergesort.Sort(arrMergesort); // Call the Sort method from the Mergesort class to sort the array

        Console.WriteLine("Array sorted (Mergesort):");
        PrintArray(arrMergesort);

        Console.WriteLine();

        Console.WriteLine("Array not sorted (Quicksort):");
        PrintArray(arrQuicksort);

        SortC.Quicksort.Sort(arrQuicksort); // Call the Sort method from the Quicksort class to sort the array

        Console.WriteLine("Array sorted (Quicksort):");
        PrintArray(arrQuicksort);

        // Now, let's compress a string using HuffmanCompression
        string inputString = "abracadabra";
        Console.WriteLine("\nOriginal string: " + inputString);

        string compressedStringHuffman = HuffmanCompression.Compress(inputString);
        Console.WriteLine("Compressed string (Huffman): " + compressedStringHuffman);

        // Now, let's compress the same string using LZWCompression
        List<int> compressedDataLZW = LZWCompression.Compress(inputString);
        Console.WriteLine("Compressed string (LZW): " + string.Join(" ", compressedDataLZW));

       { 
            string encryptionKey = "MySecretKey";
            string encryptedString = AESEncryption.Encrypt(inputString, encryptionKey);
            Console.WriteLine("String criptografada: " + encryptedString);

            // Agora, vamos descriptografar a string criptografada
            string decryptedString = AESEncryption.Decrypt(encryptedString, encryptionKey);
            Console.WriteLine("String descriptografada: " + decryptedString);
        }

        // Now, let's encrypt the string using RSAEncryption
        using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
        {
            RSAParameters publicKey = rsa.ExportParameters(false);
            RSAParameters privateKey = rsa.ExportParameters(true);

            // Now, let's encrypt the string using RSAEncryption
            string encryptedString = RSAEncryption.Encrypt(inputString, publicKey);
            Console.WriteLine("Encrypted string: " + encryptedString);

            // Now, let's decrypt the encrypted string
            string decryptedString = RSAEncryption.Decrypt(encryptedString, privateKey);
            Console.WriteLine("Decrypted string: " + decryptedString);
        }
        {
            // Exemplo de cálculo do hash SHA-256
            string inputStringSHA256 = "Hello, world!";
            string hashSHA256 = SHAHashing.ComputeSHA256Hash(inputStringSHA256);
            Console.WriteLine("SHA-256 Hash: " + hashSHA256);

            // Exemplo de cálculo do hash SHA-512
            string inputStringSHA512 = "Hello, world!";
            string hashSHA512 = SHAHashing.ComputeSHA512Hash(inputStringSHA512);
            Console.WriteLine("SHA-512 Hash: " + hashSHA512);
        }
        {
            Dictionary<string, Dictionary<string, int>> graph = new Dictionary<string, Dictionary<string, int>>
            {
                { "A", new Dictionary<string, int> { { "B", 2 }, { "C", 4 } } },
                { "B", new Dictionary<string, int> { { "C", 1 }, { "D", 7 } } },
                { "C", new Dictionary<string, int> { { "D", 3 } } },
                { "D", new Dictionary<string, int>() }
            };

            List<string> shortestPath = AStar.FindShortestPath(graph, "A", "D");

            Console.WriteLine("Shortest path from A to D: (AStar) " + string.Join(" -> ", shortestPath));
        }
        {
        Dictionary<string, List<(string, int)>> graph = new Dictionary<string, List<(string, int)>>
            {
                { "A", new List<(string, int)> { ("B", 2), ("C", 4) } },
                { "B", new List<(string, int)> { ("C", 1), ("D", 7) } },
                { "C", new List<(string, int)> { ("D", 3) } },
                { "D", new List<(string, int)>() }
            };

        Dictionary<string, int> shortestDistances = BellmanFord.FindShortestPath(graph, "A");

        foreach (KeyValuePair<string, int> entry in shortestDistances)
            {
                Console.WriteLine($"Shortest distance from A to {entry.Key}: {entry.Value} (Bellman)");
            }
        }
        {
            Dictionary<string, Dictionary<string, int>> graph = new Dictionary<string, Dictionary<string, int>>
                {
                    { "A", new Dictionary<string, int> { { "B", 2 }, { "C", 4 } } },
                    { "B", new Dictionary<string, int> { { "C", 1 }, { "D", 7 } } },
                    { "C", new Dictionary<string, int> { { "D", 3 } } },
                    { "D", new Dictionary<string, int>() }
                };

            Dictionary<string, int> shortestDistances = Dijkstra.FindShortestPath(graph, "A");

            foreach (KeyValuePair<string, int> entry in shortestDistances)
                {
                    Console.WriteLine($"Shortest distance from A to {entry.Key}: {entry.Value} (Dijkstra)");
                }
        }
        {
            List<string> availableResources = new List<string> { "ResourceA", "ResourceB", "ResourceC" };
            LeastConnectionsBalancer balancer = new LeastConnectionsBalancer(availableResources);

            for (int i = 0; i < 10; i++)
                {
                    string assignedResource = balancer.AssignTask();
                    Console.WriteLine($"Task {i + 1} assigned to {assignedResource}");
                }

            // Simulando a liberação de conexões após o término das tarefas
            balancer.ReleaseTask("ResourceA");
            balancer.ReleaseTask("ResourceC");
        }
        {
            List<string> availableResources = new List<string> { "ResourceA", "ResourceB", "ResourceC" };
            RoundRobinBalancer balancer = new RoundRobinBalancer(availableResources);

            for (int i = 0; i < 10; i++)
                {
                    string assignedResource = balancer.AssignTask();
                    Console.WriteLine($"Task {i + 1} assigned to {assignedResource}");
                }
        }
        {
            int populationSize = 50;
            int generations = 100;
            double result = GeneticAlgorithm.Optimize(populationSize, generations);
            Console.WriteLine($"Melhor solução encontrada: {result}");
        }
        {
            // Crie uma instância da classe BinaryTree
            BinaryTree tree = new BinaryTree();

            // Adicione nós à árvore
            tree.Root = new TreeNode(10);
            tree.Root.Left = new TreeNode(5);
            tree.Root.Right = new TreeNode(15);
            tree.Root.Left.Left = new TreeNode(3);
            tree.Root.Left.Right = new TreeNode(7);
            tree.Root.Right.Left = new TreeNode(12);
            tree.Root.Right.Right = new TreeNode(18);

            // Chame o método Search para procurar um valor na árvore
            int target = 7;
            TreeNode result = tree.Search(target);

            if (result != null)
            {
                Console.WriteLine($"Valor {target} encontrado na árvore.");
            }
            else
            {
                Console.WriteLine($"Valor {target} não encontrado na árvore.");
            }
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}