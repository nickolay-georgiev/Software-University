using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        public Stack<string> Stack { get; set; }
        public bool IsEmpty()
        {
            return this.Count == 0;
        }

        public void AddRange(Stack<string> items)
        {
            foreach (var item in items)
            {
                this.Push(item);
            }
        }
    }
}
