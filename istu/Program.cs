using System;



/// <summary>
/// Сортировка выбором (Selection Sort)
/// Время: O(n²), Память: O(1)
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        public static void SelectionSort(int[] arr)
        {
            if (arr == null || arr.Length <= 1) return;

            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    Swap(arr, i, minIndex);
                }
            }
        }
    }
}
