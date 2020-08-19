using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> Store;

        public int Count => this.Store.Count;

        public Box()
        {
            this.Store = new List<T>();
        }

        public void Add(T element)
        {
            this.Store.Add(element);
        }

        public T Remove()
        {
            T element = this.Store[this.Store.Count - 1];
            this.Store.RemoveAt(this.Store.Count - 1);

            return element;
        }
    }
}
