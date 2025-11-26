/// <summary>
    /// Сортировка слиянием (Merge Sort)
    /// Время: O(n log n), Память: O(n)
    /// Устойчивая, эффективна на больших данных
    /// </summary>
    public static void MergeSort(int[] arr)
    {
        if (arr == null || arr.Length <= 1) return;
        MergeSortRecursive(arr, 0, arr.Length - 1);
    }

    private static void MergeSortRecursive(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;
            MergeSortRecursive(arr, left, mid);
            MergeSortRecursive(arr, mid + 1, right);
            Merge(arr, left, mid, right);
        }
    }

    private static void Merge(int[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        int[] leftArr = new int[n1];
        int[] rightArr = new int[n2];

        Array.Copy(arr, left, leftArr, 0, n1);
        Array.Copy(arr, mid + 1, rightArr, 0, n2);

        int i = 0, j = 0, k = left;

        while (i < n1 && j < n2)
        {
            if (leftArr[i] <= rightArr[j])
            {
                arr[k++] = leftArr[i++];
            }
            else
            {
                arr[k++] = rightArr[j++];
            }
        }

        while (i < n1) arr[k++] = leftArr[i++];
        while (j < n2) arr[k++] = rightArr[j++];
    }
