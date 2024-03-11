/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode current = new ListNode();
        current = head;
        int index = 1;


        if (head == null)
        {
            return head;
        }

        while (current.next != null)
        {
            current = current.next;
            index++;
        }

        current = head;

        if (n == index)
        {
            return head.next;
        }

        for (int i = 0; i < index - n - 1; i++)
        {
            current = current.next;
        }

        current.next = current.next.next;

        return head;
    }
}