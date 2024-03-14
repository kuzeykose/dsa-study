class Solution {
    public ListNode reverseKGroup(ListNode head, int k) {
        if (head == null || k <= 1) {
            return head;
        }
        ListNode current = head;
        int count = 0;
        while (current != null && count < k) {
            current = current.next;
            count++;
        }
        if (count < k) {
            return head;
        }
        ListNode reversedHead = reverseFirstK(head, k);
        head.next = reverseKGroup(current, k);
        return reversedHead;
    }
    
    public ListNode reverseFirstK(ListNode head, int k) {
        ListNode prev = null;
        ListNode current = head;
        int count = 0;
        while (current != null && count < k) {
            ListNode next = current.next;
            current.next = prev;
            prev = current;
            current = next;
            count++;
        }
        return prev;
    }
}