using System;

namespace SortB;

class Mergesort
{
    public static void Sort(int[] arr)
    {
        int[] temp = new int[arr.Length];
        MergesortAlgorithm(arr, temp, 0, arr.Length - 1);
    }

    private static void MergesortAlgorithm(int[] arr, int[] temp, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;
            MergesortAlgorithm(arr, temp, left, mid);
            MergesortAlgorithm(arr, temp, mid + 1, right);
            Merge(arr, temp, left, mid, right);
        }
    }

    private static void Merge(int[] arr, int[] temp, int left, int mid, int right)
    {
        int i = left;
        int j = mid + 1;
        int k = left;

        while (i <= mid && j <= right)
        {
            if (arr[i] <= arr[j])
            {
                temp[k] = arr[i];
                i++;
            }
            else
            {
                temp[k] = arr[j];
                j++;
            }
            k++;
        }

        while (i <= mid)
        {
            temp[k] = arr[i];
            i++;
            k++;
        }

        while (j <= right)
        {
            temp[k] = arr[j];
            j++;
            k++;
        }

        for (k = left; k <= right; k++)
        {
            arr[k] = temp[k];
        }
    }
}
