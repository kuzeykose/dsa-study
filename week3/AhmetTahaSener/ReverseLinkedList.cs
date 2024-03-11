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
    public ListNode ReverseList(ListNode head)
    {
        Stack<int> stack = new Stack<int>();

        while (head != null)
        {
            stack.Push(head.val);
            head = head.next;
        }

        ListNode newHead = new ListNode();
        ListNode current = newHead;

        while (stack.Count > 0)
        {
            current.next = new ListNode(stack.Pop());
            current = current.next;

        }
        return newHead.next;
    }
}