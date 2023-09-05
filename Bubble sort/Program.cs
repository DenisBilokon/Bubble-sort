using System;

class BubbleSort
{
    static void Main()
    {
        int[] array = { 7, 2, 1, 9, 5, 6 };

        Console.WriteLine("Початковий масив:");
        PrintArray(array);

        BubbleSortArray(array);

        Console.WriteLine("\nВідсортований масив:");
        PrintArray(array);
    }

    static void BubbleSortArray(int[] arr)
    {
        int n = arr.Length;
        bool swapped;

        do
        {
            swapped = false;
            for (int i = 1; i < n; i++)
            {
                if (arr[i - 1] > arr[i])
                {
                    // Обміняти елементи
                    int temp = arr[i - 1];
                    arr[i - 1] = arr[i];
                    arr[i] = temp;
                    swapped = true;
                }
            }
        } while (swapped);
    }

    static void PrintArray(int[] arr)
    {
        foreach (var element in arr)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}
