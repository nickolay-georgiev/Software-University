using CollectionHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy.Models
{
    public class AddRemoveCollection : AddCollection, IAddRemoveCollection
    {
        private readonly List<string> collection;

        private List<int> addResult;

        private List<string> removeResult;

        private int currentIndex;

        public AddRemoveCollection()
        {
            this.collection = InitializaCollection();
            this.addResult = new List<int>();
            this.removeResult = new List<string>();
            this.currentIndex = 0;
        }

        public override IReadOnlyCollection<string> Collection => this.collection.AsReadOnly();

        public override IReadOnlyCollection<int> AddResult => this.addResult.AsReadOnly();

        public virtual IReadOnlyCollection<string> RemoveResult => this.removeResult.AsReadOnly();

        public override int Add(string item)
        {
            this.collection.Insert(0, item);

            this.addResult.Add(0);

            this.currentIndex += 1;

            return 0;
        }
        public virtual string Remove()
        {
            string item = this.collection[currentIndex - 1];

            this.collection.RemoveAt(currentIndex);

            this.removeResult.Add(item);

            currentIndex -= 1;

            return item;
        }
    }
}
