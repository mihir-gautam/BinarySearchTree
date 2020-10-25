using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class BinarySearchTree<T> where T: IComparable
    {
        public Node<T> root;
        public BinarySearchTree()
        {
            this.root = null;
        }
        public T NodeData { get; set; }
        public BinarySearchTree<T> LeftTree { get; set; }
        public BinarySearchTree<T> RightTree { get; set; }
        public BinarySearchTree(T nodeData)
        {
            this.NodeData = nodeData;
            this.LeftTree = null;
            this.RightTree = null;
        }
        int leftCount = 0, rightCount = 0;
        public void Insert(T item)
        {
            Node<T> node = new Node<T>(item);
            T currentNodeValue = node.NodeData;
            if (currentNodeValue.CompareTo(item) < 0)
            {
                if (this.LeftTree == null)
                {
                    this.LeftTree = new BinarySearchTree<T>(item);
                }
                else
                {
                    this.LeftTree.Insert(item);
                }
            }
            else
            {
                if (this.RightTree == null)
                {
                    this.RightTree = new BinarySearchTree<T>(item);
                }
                else
                {
                    this.RightTree.Insert(item);
                }
            }
        }
        public void Display()
        {
            if (this.LeftTree != null)
            {
                this.leftCount++;
                this.LeftTree.Display();
            }

            Console.WriteLine(this.NodeData.ToString());
            if (this.RightTree != null)
            {
                this.rightCount++;
                this.RightTree.Display();
            }
            
        }
        public void GetSize()
        {
            Console.WriteLine("Size"+" "+ (1+this.leftCount+this.rightCount));
        }
        public void IfExists(T element, BinarySearchTree<T> bst)
        {
            Node<T> node = bst.root;
            bool elementFound = false;
            while (node != null) 
            {
                if (node.NodeData.Equals(element))
                {
                    elementFound = true;
                    break;
                }
                else
                {
                    if (element.CompareTo(node.NodeData) < 0)
                    {
                        node = node.LeftTree;
                    }
                    else
                    {
                        node = node.RightTree;
                    }
                }
            }
            if (elementFound)
                Console.WriteLine("Element {0} found", element);
            else
                Console.WriteLine("Element doesn't exist in the tree");
        }
    }
}
