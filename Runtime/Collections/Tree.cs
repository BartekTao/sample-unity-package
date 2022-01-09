using System.Collections;
using System.Collections.Generic;

namespace OpenLib.Collections
{
    public class Tree<T>
    {

    }

    public class Node<T>
    {
        public Node() { }
        public Node(Node<T> next, Node<T> previous, T value)
        {
            Next = next;
            Previous = previous;
            Value = value;
        }

        public Node<T> Next { get; set; }

        public Node<T> Previous { get; set; }

        public T Value { get; set; }
    }
}

