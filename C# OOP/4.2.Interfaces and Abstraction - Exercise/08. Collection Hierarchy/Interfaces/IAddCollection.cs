using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy.Interfaces
{
    public interface IAddCollection
    {
        IReadOnlyCollection<string> Collection { get; }
        IReadOnlyCollection<int> AddResult { get; }

        int Add(string item);
    }
}
