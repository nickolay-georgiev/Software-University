using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class ListyIterator<T>
    {
        private List<T> elements;
        private int internalIndex;

        public ListyIterator(List<T> elements)
        {
            this.elements = elements;
            this.internalIndex = 0;
        }

        public bool Move()
        {
            if (this.elements.Count == 0 || this.elements.Count - 1 <= internalIndex)
            {
                return false;
            }

            this.internalIndex++;
            return true;
        }

        public void Print()
        {
            if (!this.elements.Any())
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            Console.WriteLine(this.elements[this.internalIndex]);

        }

        public bool HasNext()
        {
            if (this.internalIndex < this.elements.Count - 1)
            {
                return true;
            }

            return false;
        }
    }
}
