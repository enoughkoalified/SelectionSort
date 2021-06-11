using System;
using System.Collections.Generic;
namespace SelectionSortAlgorithm
{
    internal static class SelectionSortExtension
    {
        public static IEnumerable<T> SelectionSort<T>(this IList<T> input) where T : IComparable<T>
        {
            return new SelectionSort().Sort<T>(input);
        }

        public static ICollection<T> SelectionSortOptimized<T>(this IList<T> input) where T : IComparable<T>
        {
            return new SelectionSort().SortOptimized<T>(input);
        }
    }
}