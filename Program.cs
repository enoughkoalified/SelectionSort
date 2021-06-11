using System;
using System.Collections.Generic;

namespace SelectionSortAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //var collectionToSort = new[] { 2, 3, 1, -9, 4, 7, 8, 6 };
            var collectionToSort = GetRandomCollectionOfSize(3000);

            PerformanceMeasure(collectionToSort.SelectionSort);
            //var sortedCollection = collectionToSort.SelectionSort();
            //Console.WriteLine(string.Join(", ", sortedCollection));

            PerformanceMeasure(collectionToSort.SelectionSortOptimized);
            //var sortedCollection2 = collectionToSort.SelectionSortNoMemory();
            //Console.WriteLine(string.Join(", ", sortedCollection2));
        }

        static IList<int> GetRandomCollectionOfSize(int size)
        {
            var randomizer = new Random();
            var collection = new List<int>();
            for (var i = 0; i < size; i++)
            {
                collection.Add(randomizer.Next());
            }
            return collection;
        }

        static void PerformanceMeasure(Func<object> action)
        {
            long kbAtExecution = GC.GetTotalMemory(false) / 1024;

            action();

            long kbAfter1 = GC.GetTotalMemory(false) / 1024;
            long kbAfter2 = GC.GetTotalMemory(true) / 1024;

            Console.WriteLine(kbAtExecution + " Started with this kb.");
            Console.WriteLine(kbAfter1 + " After the test.");
            Console.WriteLine(kbAfter1 - kbAtExecution + " Kb Added.");
            Console.WriteLine();
            //Console.WriteLine(kbAfter2 + " Kb After Collection");
            //Console.WriteLine(kbAfter2 - kbAfter1 + " Amt. Collected by GC.");
        }
    }
}
