public class MyStack
{
    private ListNode top;

    public MyStack()
    {
        top = null;
    }

    public void Push(int x)
    {
        ListNode newNode = new ListNode(x);
        newNode.next = top;
        top = newNode;
    }

    public int Pop()
    {
        if (top == null)
            throw new InvalidOperationException("Stack is empty.");

        int value = top.val;
        top = top.next;
        return value;
    }

    public int Peek()
    {
        if (top == null)
            throw new InvalidOperationException("Stack is empty.");

        return top.val;
    }

    public bool IsEmpty()
    {
        return top == null;
    }
}
