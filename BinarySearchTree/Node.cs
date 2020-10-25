using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class Node<T> where T : IComparable
    {
        public T NodeData { get; set; }
        public Node<T> LeftTree { get; set; }
        public Node<T> RightTree { get; set; }
        public Node(T data)
        {
            this.NodeData = NodeData;
        }
    }
}
