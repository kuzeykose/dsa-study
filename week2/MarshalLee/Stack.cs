using System;

public class Stack<T>
{
    public int Length;
    private Node<T>? Head;

    public Stack()
    {
        this.Head = null;
        this.Length = 0;
    }

    public void Push(T data)
    {
        Node<T> node = new(data);
        this.Length++;

        if (this.Head is null)
        {
            this.Head = node;
            return;
        }

        node.Prev = this.Head;
        this.Head = node;
    }

    public T? Pop()
    {
        this.Length = Math.Max(0, this.Length - 1);

        if (this.Length == 0)
        {
            Node<T>? head0 = this.Head as Node<T>;
            this.Head = null;
            return head0.Data;
        }

        Node<T>? head = this.Head as Node<T>;
        this.Head = head.Prev;

        return head.Data;
    }

    public T? Peek<T>() where T : class
    {
        return this.Head is not null ? this.Head.Data as T : null;
    }
}
