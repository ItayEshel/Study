using System;
using System.Collections.Generic;
using System.Text;

namespace Study
{
    public class Node<T>
    {
        private T valuel;
        private Node<T> next;
        public Node(T value)
        {
            this.valuel = value;
        }
    }
}
