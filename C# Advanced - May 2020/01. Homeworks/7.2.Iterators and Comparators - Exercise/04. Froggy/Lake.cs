using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace IteratorsAndComparators
{
    public class Lake : IEnumerable<int>
    {
        private List<int> lake;

        public Lake(List<int> lake)
        {
            this.lake = lake;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.lake.Count; i++)
            {
                if (i % 2 == 0)
                {
                    yield return this.lake[i];
                }
            }

            for (int i = this.lake.Count - 1; i >= 0; i--)
            {
                if (i % 2 == 1)
                {
                    yield return this.lake[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
