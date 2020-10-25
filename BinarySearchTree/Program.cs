﻿using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Binary Search Tree Program");
            BinarySearchTree<int> bst = new BinarySearchTree<int>(56);
            bst.Insert(56);
            bst.Insert(30);
            bst.Insert(70);
            bst.Display();
        }
    }
}
