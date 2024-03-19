using System;

public static ListNode ReverseList(ListNode head)
{
    ListNode previousNode = null;
    while (head != null)
    {
        ListNode currNext = head.next;
        head.next = previousNode;
        previousNode = head;
        head = currNext;
    }
    return previousNode;
    //ListNode previous = null;
    //ListNode curr = head;
    //while(curr != null)
    //{
    //    ListNode next = curr.next;
    //    curr.next = previous;
    //    previous = curr;
    //    curr = next;
    //}
    //return previous;
}