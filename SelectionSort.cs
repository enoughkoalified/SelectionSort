using System;
using System.Collections.Generic;
using System.Linq;

namespace SelectionSortAlgorithm
{
    internal class SelectionSort: ICustomSort
    {
        public IEnumerable<T> Sort<T>(IList<T> collection) where T : IComparable<T> 
        {
            if (collection == null)
                throw new NullReferenceException("Selection Sort Collection is null");

            if (collection.Count() == 0)
                return collection;

            var sortedCollection = new List<T>();
            do
            {
                var smallest = collection.First();
                var smallestIndex = 0;

                for (var i = 0; i < collection.Count(); i++)
                {
                    var item = collection.ElementAt(i);
                    if (item.CompareTo(smallest) < 0)
                    {
                        smallest = item;
                        smallestIndex = i;
                    }
                }
                sortedCollection.Add(smallest);
                collection.Remove(smallest);
            }
            while (collection.Count() != 0);

            return sortedCollection;
        }

        public ICollection<T> SortOptimized<T>(IList<T> collection) where T : IComparable<T> 
        {
            if (collection == null)
                throw new NullReferenceException("Selection Sort Collection is null");

            if (collection.Count() == 0)
                return collection;

            var sortedElementsCounter = 0;

            do
            {
                var smallest = collection.Skip(sortedElementsCounter).Min();
                var smallestIndex = collection.IndexOf(smallest);

                collection.Swap(sortedElementsCounter, smallestIndex);

                sortedElementsCounter++;
            }
            while (sortedElementsCounter < collection.Count() - 1);

            return collection;
        }
    }
}