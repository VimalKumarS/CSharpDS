using System;
using System.Collections.Generic;
using System.Text;

namespace TreeSort
{
    class Node
    {
        public int item;
        public Node leftChild;
        public Node rightChild;
        public void displayNode()
        {
            Console.Write("[");
            Console.Write(item);
            Console.Write("]");
        }
    }
    class Tree
    {
        public Node root;
        public Tree()
        { root = null; }
        public Node ReturnRoot()
        {
            return root;
        }
        public void Insert(int id)
        {
            Node newNode = new Node();
            newNode.item = id;
            if (root == null)
                root = newNode;
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (id < current.item)
                    {
                        current = current.leftChild;
                        if (current == null)
                        {
                            parent.leftChild = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.rightChild;
                        if (current == null)
                        {
                            parent.rightChild = newNode;
                            return;
                        }
                    }
                }
            }
        }
        public void Preorder(Node Root)
        {
            if (Root != null)
            {
                Console.Write(Root.item + " ");
                Preorder(Root.leftChild);
                Preorder(Root.rightChild);
            }
        }
        public void Inorder(Node Root)
        {
            if (Root != null)
            {
                Inorder(Root.leftChild);
                Console.Write(Root.item + " ");
                Inorder(Root.rightChild);
            }
        }
        public void Postorder(Node Root)
        {
            if (Root != null)
            {
                Postorder(Root.leftChild);
                Postorder(Root.rightChild);
                Console.Write(Root.item + " ");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Tree theTree = new Tree();
            theTree.Insert(42);
            theTree.Insert(25);
            theTree.Insert(65);
            theTree.Insert(12);
            theTree.Insert(37);
            theTree.Insert(13);
            theTree.Insert(30);
            theTree.Insert(43);
            theTree.Insert(87);
            theTree.Insert(99);
            theTree.Insert(9);

            Console.WriteLine("Inorder traversal resulting Tree Sort");
            theTree.Inorder(theTree.ReturnRoot());
            Console.WriteLine(" ");

            Console.WriteLine();
            Console.WriteLine("Preorder traversal");
            theTree.Preorder(theTree.ReturnRoot());
            Console.WriteLine(" ");

            Console.WriteLine();
            Console.WriteLine("Postorder traversal");
            theTree.Postorder(theTree.ReturnRoot());
            Console.WriteLine(" ");

            Console.ReadLine();
        }
    }
}