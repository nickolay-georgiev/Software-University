using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class ListyIterator<T> : IEnumerable<T>
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

        public void PrintAll()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in this.elements)
            {
                sb.Append(item + " ");
            }

            Console.WriteLine(sb.ToString().TrimEnd());
        }

        public bool HasNext()
        {
            if (this.internalIndex < this.elements.Count - 1)
            {
                return true;
            }

            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in this.elements)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
