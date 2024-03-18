using System;

public bool HasCycle(ListNode head)
{
    HashSet<ListNode> visited = new();
    ListNode currentNode = head;
    while (currentNode != null)
    {
        if (visited.Contains(currentNode))
        {
            return true;
        }
        visited.Add(currentNode);
        currentNode = currentNode.next;
    }
    return false;
    //if (head == null) return false;

    //ListNode fast = head;
    //ListNode slow = head;

    //while (fast.next != null && fast.next.next != null)
    //{
    //    fast = fast.next.next;
    //    slow = slow.next;

    //    if (fast == slow) return true;
    //}
    //return false;
}
