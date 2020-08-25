using System;
using System.Text;

namespace Workshop1
{
    public class DoublyLinkedList<T>
    {
        private class ListNode
        {
            public ListNode(T value)
            {
                this.Value = value;
            }

            public ListNode NextNode { get; set; }
            public ListNode PreviousNode { get; set; }
            public T Value { get; set; }
        }

        private ListNode head;
        private ListNode tail;

        public int Count { get; private set; }

        public void AddFirst(T element)
        {
            var newHead = new ListNode(element);

            if (this.Count == 0)
            {
                this.head = newHead;
                this.tail = newHead;
            }
            else
            {
                newHead.NextNode = this.head;
                this.head.PreviousNode = newHead;
                this.head = newHead;
            }

            this.Count++;
        }

        public void AddLast(T element)
        {
            ListNode newTail = new ListNode(element);

            if (this.Count == 0)
            {
                this.head = newTail;
                this.tail = newTail;
            }
            else
            {
                newTail.PreviousNode = this.tail;
                this.tail.NextNode = newTail;
                this.tail = newTail;
            }

            this.Count++;
        }

        public T RemoveFirst()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("DoublyLinkedList is empty!");
            }

            T removedElement = this.head.Value;
            ListNode newHead = this.head.NextNode;

            if (this.Count == 1)
            {
                this.head = null;
                this.tail = null;
            }
            else
            {
                this.head.PreviousNode = null;
                this.head = newHead;
            }

            this.Count--;

            return removedElement;
        }

        public T RemoveLast()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("DoublyLinkedList is empty!");
            }

            T removedElement = this.tail.Value;
            ListNode newTail = this.tail.PreviousNode;

            if (this.Count == 1)
            {
                this.head = null;
                this.tail = null;
            }
            else
            {
                newTail.NextNode = null;
                this.tail = newTail;
            }

            this.Count--;

            return removedElement;
        }

        public void ForEach(Action<T> action)
        {
            ListNode currentNode = this.head;

            while (currentNode != null)
            {
                action(currentNode.Value);

                currentNode = currentNode.NextNode;
            }
        }

        public void Clear()
        {
            this.tail = null;
            this.head = null;

            this.Count = 0;
        }
        public T[] ToArray()
        {
            T[] array = new T[this.Count];
            int counter = 0;

            var currentNode = this.head;

            while (currentNode != null)
            {
                array[counter] = currentNode.Value;
                currentNode = currentNode.NextNode;

                counter++;
            }

            return array;
        }
    }
}
