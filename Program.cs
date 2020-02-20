using System;

namespace SortingAndStrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();
            for (int i = 0; i <= 2; i++)
            {
                var array = dataService.GenerateIntArray((i + 1) * 3);
                Console.WriteLine("Initial Status of Array: ");
                Common.printArray(array);
                switch (array.Length)
                {
                    case 3:
                        Console.WriteLine("===============" + "Bubble Sort" + "===============");
                        strategy.BubbleSortStrategy.BubbleSort(array);
                        break;
                    case 6:
                        Console.WriteLine("===============" + "Insertion Sort" + "===============");
                        strategy.InsertionSortStrategy.InsertionSort(array);
                        break;
                    default:
                        Console.WriteLine("===============" + "Merge Sort" + "===============");;
                        strategy.MergeSortStrategy.MergeSort(array, 0, array.Length - 1);
                        break;
                }
                Console.WriteLine("Final Status of Array: ");
                Common.printArray(array);
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
