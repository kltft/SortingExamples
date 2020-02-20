using System;

namespace SortingAndStrategyPattern.strategy
{
    public static class BubbleSortStrategy
    {
        public static void BubbleSort(int[] arr)
        {
			Console.WriteLine("Initial Status of Array: ");
            Common.printArray(arr);

            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("Current Status of Array: ");
                Common.printArray(arr);
                for (int j = 0; j < n - i - 1; j++)
                {
                    Console.WriteLine("Comparing {0} at position {1} and {2} at position {3}", arr[j], j, arr[j + 1], j + 1);
                    if (arr[j] > arr[j + 1])
                    {
                        Console.WriteLine("performing swap");
                        // swap temp and arr[i] 
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}