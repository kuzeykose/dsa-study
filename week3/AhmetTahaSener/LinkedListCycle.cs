/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution
{
    public bool HasCycle(ListNode head)
    {

        if (head == null || head.next == null)
        {
            return false;
        }

        ListNode fast = new ListNode();
        ListNode slow = new ListNode();

        fast = head;
        slow = head;

        while (fast.next != null && fast.next.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;

            if (fast == slow)
            {
                return true;
            }
        }

        return false;
    }
}