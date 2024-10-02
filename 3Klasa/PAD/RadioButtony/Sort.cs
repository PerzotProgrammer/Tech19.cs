namespace RadioButtony;

/// <summary>
/// KLASA NAPISANA PRZEZE MNIE JESZCZE W 1 KLASIE
/// </summary>

public static class Sort
{
    public static int[] CreateArray()
    {
        Console.Write("Podaj długość tablicy: ");
        int length = Convert.ToInt32(Console.ReadLine());
        return new int[length];
    }

    public static void AutoFillArray(int[] array, int min = 1, int max = 100)
    {
        Random random = new();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(min, max);
        }
    }

    public static void ManualFillArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Podaj {i + 1} element tablicy:");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    public static void PrintArray(int[] array, string message)
    {
        Console.WriteLine(message);
        foreach (int element in array)
        {
            Console.Write($"{element}, ");
        }

        Console.WriteLine();
    }

    public static void ReverseArray(int[] array)
    {
        for (int i = 0; i < array.Length / 2; i++)
        {
            (array[array.Length - i - 1], array[i]) = (array[i], array[array.Length - i - 1]);
        }
    }

    public static void SelectionSort(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int temp = i;

            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[temp]) temp = j;
            }

            (array[temp], array[i]) = (array[i], array[temp]);
        }
    }

    public static void BubbleSort(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
                }
            }
        }
    }

    public static void InsertionSort(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int temp = array[i];
            int j;
            for (j = i - 1; j >= 0 && array[j] > temp; j--)
            {
                array[j + 1] = array[j];
            }

            array[j + 1] = temp;
        }
    }

    public static void MergeSort(int[] array)
    {
        if (array.Length <= 1) return;
        int[] leftArr = new int[array.Length / 2];
        int[] rightArr = new int[array.Length - array.Length / 2];

        int i = 0;
        int j = 0;

        for (; i < array.Length; i++)
        {
            if (i < array.Length / 2) leftArr[i] = array[i];
            else
            {
                rightArr[j] = array[i];
                j++;
            }
        }

        MergeSort(leftArr);
        MergeSort(rightArr);
        Merge(leftArr, rightArr, array);
    }

    private static void Merge(int[] leftArr, int[] rightArr, int[] array)
    {
        int i = 0;
        int l = 0;
        int r = 0;
        while (l < array.Length / 2 && r < array.Length - array.Length / 2)
        {
            if (leftArr[l] < rightArr[r])
            {
                array[i] = leftArr[l];
                i++;
                l++;
            }
            else
            {
                array[i] = rightArr[r];
                i++;
                r++;
            }
        }

        while (l < array.Length / 2)
        {
            array[i] = leftArr[l];
            i++;
            l++;
        }

        while (r < array.Length - array.Length / 2)
        {
            array[i] = rightArr[r];
            i++;
            r++;
        }
    }

    public static void QuickSort(int[] array, int start = 0, int end = -1)
    {
        if (end == -1) end = array.Length - 1;
        if (end <= start) return;

        int pivot = Partition(array, start, end);
        QuickSort(array, start, pivot - 1);
        QuickSort(array, pivot + 1, end);
    }

    private static int Partition(int[] array, int start, int end)
    {
        int pivot = array[end];
        int i = start - 1;

        for (int j = start; j <= end - 1; j++)
        {
            if (array[j] < pivot)
            {
                i++;
                (array[i], array[j]) = (array[j], array[i]);
            }
        }

        i++;
        (array[i], array[end]) = (array[end], array[i]);
        return i;
    }
}