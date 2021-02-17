using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy.Interfaces
{
    public interface IAddRemoveCollection : IAddCollection
    {
        IReadOnlyCollection<string> RemoveResult { get; }
        string Remove();
    }
}
