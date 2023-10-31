using System;
using System.Collections.Generic;

namespace LZW;

class LZWCompression
{
    public static List<int> Compress(string input)
    {
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        for (int i = 0; i < 256; i++)
        {
            dictionary[((char)i).ToString()] = i;
        }

        List<int> compressedData = new List<int>();
        string current = string.Empty;

        foreach (char symbol in input)
        {
            string currentPlusSymbol = current + symbol;
            if (dictionary.ContainsKey(currentPlusSymbol))
            {
                current = currentPlusSymbol;
            }
            else
            {
                compressedData.Add(dictionary[current]);
                dictionary[currentPlusSymbol] = dictionary.Count;
                current = symbol.ToString();
            }
        }

        if (!string.IsNullOrEmpty(current))
        {
            compressedData.Add(dictionary[current]);
        }

        return compressedData;
    }
}
