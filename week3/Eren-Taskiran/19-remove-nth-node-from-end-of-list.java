class Solution {
    public ListNode removeNthFromEnd(ListNode head, int n) {
       ListNode ans = new ListNode(0);
        ans.next = head;
        
        int length = 0;
        ListNode tmp = head;
        while (tmp != null) {
            length++;
            tmp = tmp.next;
        }
        
        length -= n;
        tmp = ans;
        while (length > 0) {
            length--;
            tmp = tmp.next;
        }
        
        tmp.next = tmp.next.next;
        
        return ans.next;
    }
}