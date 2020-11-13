using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericsAndCollection
{
    public class MyStack<T> : IEnumerable<T>
    {
        Node<T> head;

        int count;
        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }

        public T First
        {
            get
            {
                if (IsEmpty)
                    throw new InvalidOperationException();
                return head.Data;
            }
        }


        public void Push(T item)
        {
            Node<T> node = new Node<T>(item);
            node.Next = head;
            head = node;
            count++;
        }
        public T Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException();
            Node<T> temp = head;
            head = head.Next;
            count--;
            return temp.Data;
        }
        public T Peek()
        {
            if (IsEmpty)
                throw new InvalidOperationException();
            return head.Data;
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}