using System;
    
    int[] array = [10, 9, 8, 7, 6, 4, 2, 1];
    quickSort(array, 0, array.Length - 1);
    Console.WriteLine(string.Join(", ", array));
    
     static void quickSort(int[] array, int start, int end)
    {
        if (end <= start) return;


        int pivot = partition(array, start, end);
        quickSort(array, start, pivot - 1);
        quickSort(array, pivot + 1, end);
    }
    static int partition(int[] array, int start, int end)
    {
        int pivot = array[end];
        int i = start - 1;


        for (int j = start; j < end; j++)
        {
            if (array[j] < pivot)
            {
                i++;
                (array[j], array[i]) = (array[i], array[j]);

            }
        
          }
        
        (array[i + 1], array[end]) = (array[end], array[i + 1]);
        return i + 1;
        }

