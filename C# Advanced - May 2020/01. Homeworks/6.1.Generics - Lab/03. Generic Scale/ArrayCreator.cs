using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace GenericScale
{
    public class EqualityScale<T> where T : IComparable<T>
    {
        public EqualityScale(T leftElement, T rightElement)
        {
            this.leftElement = leftElement;
            this.rightElement = rightElement;
        }

        private T leftElement { get; set; }

        private T rightElement { get; set; }


        public bool AreEqual()
        {
            if (this.leftElement.CompareTo(this.rightElement) != 0)
            {
                return default;
            }

            return this.leftElement.CompareTo(this.rightElement) == 0;
        }
    }
}
