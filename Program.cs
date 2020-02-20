using System;

namespace SortingAndStrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();
            Console.WriteLine("===============" + "Bubble Sort" + "===============");
            var firstArray = dataService.GenerateIntArray(5);
            strategy.BubbleSortStrategy.BubbleSort(firstArray);
            Console.WriteLine("Final Status of Array: ");
            Common.printArray(firstArray);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("===============" + "Insertion Sort" + "===============");
            var secondArray = dataService.GenerateIntArray(5);
            strategy.InsertionSortStrategy.InsertionSort(secondArray);
            Console.WriteLine("Final Status of Array: ");
            Common.printArray(secondArray);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("===============" + "Merge Sort" + "===============");
            var thirdArray = dataService.GenerateIntArray(7);
            Console.WriteLine("Initial Status of Array: ");
            Common.printArray(thirdArray);
            strategy.MergeSortStrategy.MergeSort(thirdArray, 0, thirdArray.Length - 1);
            Console.WriteLine("Final Status of Array: ");
            Common.printArray(thirdArray);
        }
    }
}
