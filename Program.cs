using System;
using Huff;
using LZW;
using Encrypt; // Certifique-se de adicionar o namespace para a classe AESEncryption

class Program
{
    static void Main()
    {
        int[] arrHeapsort = { 12, 11, 13, 5, 6, 7 }; // Crie um array de inteiros para ordenar com Heapsort
        int[] arrMergesort = { 12, 11, 13, 5, 6, 7 }; // Crie um array de inteiros para ordenar com Mergesort
        int[] arrQuicksort = { 12, 11, 13, 5, 6, 7 }; // Crie um array de inteiros para ordenar com Quicksort

        Console.WriteLine("Array não ordenado (Heapsort):");
        PrintArray(arrHeapsort);

        SortA.Heapsort.Sort(arrHeapsort); // Chame o método Sort da classe Heapsort para ordenar o array

        Console.WriteLine("Array ordenado (Heapsort):");
        PrintArray(arrHeapsort);

        Console.WriteLine();

        Console.WriteLine("Array não ordenado (Mergesort):");
        PrintArray(arrMergesort);

        SortB.Mergesort.Sort(arrMergesort); // Chame o método Sort da classe Mergesort para ordenar o array

        Console.WriteLine("Array ordenado (Mergesort):");
        PrintArray(arrMergesort);

        Console.WriteLine();

        Console.WriteLine("Array não ordenado (Quicksort):");
        PrintArray(arrQuicksort);

        SortC.Quicksort.Sort(arrQuicksort); // Chame o método Sort da classe Quicksort para ordenar o array

        Console.WriteLine("Array ordenado (Quicksort):");
        PrintArray(arrQuicksort);

        // Agora, vamos comprimir uma string usando HuffmanCompression
        string inputString = "abracadabra";
        Console.WriteLine("\nString original: " + inputString);

        string compressedStringHuffman = HuffmanCompression.Compress(inputString);
        Console.WriteLine("String comprimida (Huffman): " + compressedStringHuffman);

        // Agora, vamos comprimir a mesma string usando LZWCompression
        List<int> compressedDataLZW = LZWCompression.Compress(inputString);
        Console.WriteLine("String comprimida (LZW): " + string.Join(" ", compressedDataLZW));

        // Agora, vamos criptografar a string usando AESEncryption
        string encryptionKey = "MySecretKey";
        string encryptedString = AESEncryption.Encrypt(inputString, encryptionKey);
        Console.WriteLine("String criptografada: " + encryptedString);

        // Agora, vamos descriptografar a string criptografada
        string decryptedString = AESEncryption.Decrypt(encryptedString, encryptionKey);
        Console.WriteLine("String descriptografada: " + decryptedString);
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
