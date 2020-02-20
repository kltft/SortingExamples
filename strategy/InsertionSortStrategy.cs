using System;

namespace SortingAndStrategyPattern.strategy
{
    public static class InsertionSortStrategy
    {
        public static void InsertionSort(int[] arr)
        {
			Console.WriteLine("Initial Status of Array: ");
            Common.printArray(arr);

            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                Console.WriteLine("Current Status of Array: ");
                Common.printArray(arr);
                int key = arr[i];
                Console.WriteLine("Current value to evaluate is {0} at position {1}", key, i);
                int j = i - 1;

                // Move elements of arr[0..i-1], 
                // that are greater than key, 
                // to one position ahead of 
                // their current position 
                while (j >= 0 && arr[j] > key)
                {
                    Console.WriteLine("{0} was found to be less than the value in the next lower position: {1} which was at position {2}.", key, arr[j], j);
                    Console.WriteLine("Moving {0} up one, which will now be stored at position {1}", arr[j], j + 1);
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }
    }
}