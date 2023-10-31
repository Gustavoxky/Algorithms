using System;

namespace SortC;

class Quicksort
{
    public static void Sort(int[] arr)
    {
        QuicksortAlgorithm(arr, 0, arr.Length - 1);
    }

    private static void QuicksortAlgorithm(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = Partition(arr, left, right);
            QuicksortAlgorithm(arr, left, pivotIndex - 1);
            QuicksortAlgorithm(arr, pivotIndex + 1, right);
        }
    }

    private static int Partition(int[] arr, int left, int right)
    {
        int pivot = arr[right];
        int i = left - 1;

        for (int j = left; j < right; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                Swap(arr, i, j);
            }
        }

        Swap(arr, i + 1, right);
        return i + 1;
    }

    private static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}
