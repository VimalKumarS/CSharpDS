using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkList
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
public class Node
{
    public Node(int data)
    {
        this.data = data;
    }
    public Object data { get; set; }

    public Node Next { get; set; }
}
public class LinkedList
{
    Node _head;
    Node _tail;

    public LinkedList()
    { }


    public void AddLast(int data)
    {
        Node _newNode = new Node(data);
        if (_head == null)
        {
            _tail = _newNode;
            _head = _tail;
        }
        else
        {
            _tail.Next = _newNode;
            _tail = _newNode;
        }
    }

    public void Clear()
    {
        _head = null;
    }

    public void AddFirst(int data)
    {
        Node _newNode = new Node(data);
        if (_head == null)
        {
            _head = _newNode;
            _tail = _head;
        }
        else
        {
            _newNode.Next = _head;
            _head = _newNode;
        }
    }

    public Node FindNode(int data)
    {
        Node _current = _head;
        while (_current != null)
        {
            if ((int)_current.data == data)
                return _current;
            else
                _current = _current.Next;
        }
        return _current;
    }


    public void PrintList()
    {
        Node _current = _head;

        if (_head == null)
            Console.WriteLine("Empty Linked List");
        else
        {
            while (_current != null)
            {
                Console.Write(_current.data.ToString() + " ");
                _current = _current.Next;
            }
            Console.WriteLine();
        }
    }

    public void InsertAfter(int data, int _newData)
    {
        Node _newNode = new Node(_newData);
        Node _node = FindNode(data);
        if (_node != null)
        {
            _newNode.Next = _node.Next;
            _node.Next = _newNode;
        }
        else
        {
            Console.WriteLine("No such data:" + data);
        }
    }

    public void InsertBefore(int data, int _newData)
    {
        Node _newNode = new Node(_newData);
        Node _current = _head;
        Node _previous = _current;
        while (_current != null)
        {
            if ((int)_current.data == data)
            {
                _newNode.Next = _current;
                _previous.Next = _newNode;
                break;
            }
            else
            {
                _previous = _current;
                _current = _current.Next;
            }
        }
    }

    public void Remove(int data)
    {
        Node _current = _head;

        while (_current.Next != null)
        {
            if ((int)_current.Next.data == data)
            {
                _current.Next = _current.Next.Next;
                break;
            }
            else
                _current = _current.Next;
        }
    }

    public void RemoveDuplicatesUsingBuffer()
    {
        HashSet<int> _hashSet = new HashSet<int>();
        Node _current = _head;
        Node _previous = _current;
        while (_current != null)
        {
            if (_hashSet.Contains((int)_current.data))
            {
                _previous.Next = _previous.Next.Next;
                _current = _previous.Next;
            }
            else
            {
                _hashSet.Add((int)_current.data);
                _previous = _current;
                _current = _current.Next;
            }
        }
    }

    public void RemoveDuplicates()
    {
        Node _current = _head;
        Node _previous = _current;
        Node _curr = _current;

        while (_current != null)
        {
            _curr = _head;
            bool isDuplicate = false;
            while (_curr != _current)
            {
                if ((int)_curr.data == (int)_current.data)
                {
                    isDuplicate = true;
                    break;
                }
                else
                    _curr = _curr.Next;
            }

            if (isDuplicate)
            {
                _previous.Next = _previous.Next.Next;
                _current = _previous.Next;
            }
            else
            {
                _previous = _current;
                _current = _current.Next;
            }
        }
    }


    public void Reverse()
    {
        Stack<Node> _stack = new Stack<Node>();
        Node _current = _head;
        while (_current != null)
        {
            _stack.Push(_current);
            _current = _current.Next;
        }

        _head = _stack.Pop();
        _current = _head;
        while (_stack.Count > 0)
        {
            _current.Next = _stack.Pop();
            _current = _current.Next;
        }
        _current.Next = null;
    }

    public void FindNthElementFromLast(int n)
    {
        Node _p1 = _head;
        Node _p2 = _p1;

        for (int i = 0; i < (n - 1); i++)
        {
            _p2 = _p2.Next;
        }

        while (_p2.Next != null)
        {
            _p1 = _p1.Next;
            _p2 = _p2.Next;
        }

        Console.WriteLine(_p1.data.ToString());
    }

    public Node First
    {
        get
        {
            return _head;
        }
    }

}