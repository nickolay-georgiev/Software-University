using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        public List<Book> library { get; set; } 

        public Library(params Book[] books)
        {
            this.library = new List<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return this.library.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
