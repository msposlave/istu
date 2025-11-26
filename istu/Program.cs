using System;



public static class SortingAlgorithms
{
    /// <summary>
    /// Сортировка пузырьком (Bubble Sort)
    /// Время: O(n²), Память: O(1)
    /// </summary>
    public static void BubbleSort(int[] arr)
    {
        if (arr == null || arr.Length <= 1) return;

        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            bool swapped = false;
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    Swap(arr, j, j + 1);
                    swapped = true;
                }
            }
            // Если не было перестановок — массив отсортирован
            if (!swapped) break;
        }
    }
}
