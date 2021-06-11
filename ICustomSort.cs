using System;
using System.Collections.Generic;

namespace SelectionSortAlgorithm
{
    //TODO: move to another project and link here, possibly will be removed
    public interface ICustomSort
    {
        IEnumerable<T> Sort<T>(IList<T> collection) where T : IComparable<T>;
    }
}