using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Huff;

class HuffmanNode
{
    public char Symbol { get; set; }
    public int Frequency { get; set; }
    public HuffmanNode? Left { get; set; }
    public HuffmanNode? Right { get; set; }

}

class HuffmanCompression
{
    public static string Compress(string input)
    {
        Dictionary<char, int> frequencies = input
            .GroupBy(c => c)
            .ToDictionary(group => group.Key, group => group.Count());

        List<HuffmanNode> nodes = frequencies
            .Select(pair => new HuffmanNode { Symbol = pair.Key, Frequency = pair.Value })
            .ToList();

        while (nodes.Count > 1)
        {
            nodes = nodes.OrderBy(node => node.Frequency).ToList();

            HuffmanNode left = nodes[0];
            HuffmanNode right = nodes[1];

            nodes.Remove(left);
            nodes.Remove(right);

            HuffmanNode parent = new HuffmanNode
            {
                Symbol = '\0',
                Frequency = left.Frequency + right.Frequency,
                Left = left,
                Right = right
            };

            nodes.Add(parent);
        }

        Dictionary<char, string> codes = new Dictionary<char, string>();
        CreateCodes(nodes[0], "", codes);

        StringBuilder compressedData = new StringBuilder();
        foreach (char symbol in input)
        {
            compressedData.Append(codes[symbol]);
        }

        return compressedData.ToString();
    }

    private static void CreateCodes(HuffmanNode? node, string code, Dictionary<char, string> codes)
    {
        if (node == null)
        {
            return; // Saia da função se 'node' for nulo
        }

        if (node!.Symbol != '\0') // Use 'node!' para indicar que você tem certeza de que 'node' não é nulo
        {
            codes[node.Symbol] = code;
        }
        else
        {
            CreateCodes(node.Left, code + "0", codes);
            CreateCodes(node.Right, code + "1", codes);
        }
    }   
}
