using System;

public class Node<T>
{
    public T Data { get; set; }
    public Node<T> Next { get; internal set; }
    public Node<T>? Prev { get; internal set; }

    public Node(T data)
    {
        this.Data = data;
    }
}

public class LinkedList<T>
{
    public Node<T> First { get; private set; }
    public Node<T> Last { get; private set; }
    public int Count { get; private set; }

    public LinkedList()
    {
        this.First = null;
        this.Last = null;
    }

    public void AddFirst(Node<T> newNode)
    {
        if (this.First == null)
        {
            this.First = newNode;
            this.Last = newNode;
        }
        else
        {
            newNode.Next = this.First;
            this.First = newNode;
        }
        this.Count++;
    }

    public void AddLast(Node<T> newNode)
    {
        if (this.First == null)
        {
            this.First = newNode;
            this.Last = newNode;
        }
        else
        {
            this.Last.Next = newNode;
            Last = newNode;
        }
        this.Count++;
    }

    public void AddAfter(Node<T> newNode, Node<T> existingNode)
    {
        if (this.Last == existingNode)
        {
            Last = newNode;
        }
        newNode.Next = existingNode.Next;
        existingNode.Next = newNode;
        this.Count++;
    }

    public Node<T> Find(T target)
    {
        Node<T> currentNode = First;

        while (currentNode != null && !currentNode.Data.Equals(target))
        {
            currentNode = currentNode.Next;
        }

        return currentNode;
    }

    public void RemoveFirst()
    {
        if (First == null || this.Count == 0)
            return;

        First = First.Next;
        this.Count--;
    }

    public void Remove(Node<T> nodeToRemove)
    {
        if (First == null || this.Count == 0)
        {
            return;
        }
        if (this.First == nodeToRemove)
        {
            this.RemoveFirst();
            return;
        }

        Node<T> previous = First;
        Node<T> current = previous.Next;

        while (current != null && current != nodeToRemove)
        {
            previous = current;
            current = previous.Next;
        }

        if (current != null)
        {
            previous.Next = current.Next;
            this.Count--;
        }
    }

    public void Traverse()
    {
        Console.WriteLine("First:" + First.Data);
        Console.WriteLine("\nLast:" + Last.Data);

        Node<T> node = this.First;

        while (node.Next is not null)
        {
            Console.WriteLine(node.Data);
            node = node.Next;
        }
        Console.WriteLine(node.Data);
    }
}