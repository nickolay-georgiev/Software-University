using CollectionHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy.Models
{
    class MyList : AddRemoveCollection, IMyList
    {
        private List<string> collection;

        private List<int> addResult;

        private List<string> removeResult;

        private int currentIndex;

        public MyList()
        {
            this.collection = InitializaCollection();
            this.addResult = new List<int>();
            this.removeResult = new List<string>();
            this.currentIndex = 0;
        }
        public sealed override IReadOnlyCollection<string> Collection => this.collection.AsReadOnly();

        public sealed override IReadOnlyCollection<int> AddResult => this.addResult.AsReadOnly();

        public sealed override IReadOnlyCollection<string> RemoveResult => this.removeResult;

        public sealed override int Add(string item)
        {
            this.collection.Insert(0, item);

            addResult.Add(0);

            this.currentIndex += 1;

            return 0;
        }
        public sealed override string Remove()
        {
            int index = 0;

            string item = this.collection[index];

            removeResult.Add(item);

            this.collection.RemoveAt(index);

            currentIndex -= 1;

            return item;
        }

        public string Used()
        {
            return string.Join(" ", this.collection);
        }

    }
}
