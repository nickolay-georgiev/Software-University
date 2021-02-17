using System;
using System.Collections.Generic;
using System.Text;

using CollectionHierarchy.Interfaces;

namespace CollectionHierarchy.Models
{
    public class AddCollection : IAddCollection
    {
        private List<string> collection;

        private List<int> addResult;

        private int currentIndex;

        public AddCollection()
        {
            this.collection = InitializaCollection();
            this.addResult = new List<int>();
            this.currentIndex = 0;

        }

        public virtual IReadOnlyCollection<string> Collection => this.collection.AsReadOnly();

        public virtual IReadOnlyCollection<int> AddResult => this.addResult.AsReadOnly();

        public virtual int Add(string item)
        {
            this.collection.Insert(currentIndex, item);
            
            this.addResult.Add(currentIndex);

            this.currentIndex += 1;

            return currentIndex;
        }

        protected List<string> InitializaCollection()
        {
            var temp = new List<string>();

            for (int i = 0; i < 100; i++)
            {
                temp.Add("");
            }

            return temp;
        }
    }
}
