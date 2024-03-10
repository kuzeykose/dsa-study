public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class MyLinkedList
{
    private ListNode head;
    private int size;

    public MyLinkedList()
    {
        head = null;
        size = 0;
    }

    public int Get(int index)
    {
        if (index < 0 || index >= size)
            return -1;

        ListNode curr = head;
        for (int i = 0; i < index; i++)
        {
            curr = curr.next;
        }
        return curr.val;
    }

    public void AddAtHead(int val)
    {
        ListNode newNode = new ListNode(val);
        newNode.next = head;
        head = newNode;
        size++;
    }

    public void AddAtTail(int val)
    {
        if (head == null)
        {
            AddAtHead(val);
            return;
        }

        ListNode newNode = new ListNode(val);
        ListNode curr = head;
        while (curr.next != null)
        {
            curr = curr.next;
        }
        curr.next = newNode;
        size++;
    }

    public void AddAtIndex(int index, int val)
    {
        if (index < 0 || index > size)
            return;

        if (index == 0)
        {
            AddAtHead(val);
            return;
        }

        if (index == size)
        {
            AddAtTail(val);
            return;
        }

        ListNode newNode = new ListNode(val);
        ListNode prev = head;
        for (int i = 0; i < index - 1; i++)
        {
            prev = prev.next;
        }
        newNode.next = prev.next;
        prev.next = newNode;
        size++;
    }

    public void DeleteAtIndex(int index)
    {
        if (index < 0 || index >= size)
            return;

        if (index == 0)
        {
            head = head.next;
            size--;
            return;
        }

        ListNode prev = head;
        for (int i = 0; i < index - 1; i++)
        {
            prev = prev.next;
        }
        prev.next = prev.next.next;
        size--;
    }
}
