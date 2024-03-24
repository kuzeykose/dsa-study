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
public class Solution {
    public bool HasCycle(ListNode head) {
         if (head == null || head.next == null) {
            return false; 
        }

        ListNode slow = head, fast = head.next;
        
         while (slow != fast) {
            if (fast == null || fast.next == null) {
                return false; 
            }
            slow = slow.next;
            fast = fast.next.next;
        }

        return true; 
    }
}